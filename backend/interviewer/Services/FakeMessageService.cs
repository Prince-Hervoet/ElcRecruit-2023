using interviewer.Data;
using StackExchange.Redis;

namespace interviewer.Services;

class FakeMessageService : MessageServiceBase
{
    public FakeMessageService(IConfiguration configuration, MessageSettings messageSettings)
    {
        _configuration = configuration;
        _messageSettings = messageSettings;
        var redisAddress = _configuration["RedisAddress"] ?? throw new Exception("找不到 RedisAddress 的配置");
        _redis = ConnectionMultiplexer.Connect(redisAddress);
        _redisDb = _redis.GetDatabase();
    }

    private readonly IConfiguration _configuration;
    private readonly MessageSettings _messageSettings;
    private readonly ConnectionMultiplexer _redis;
    private readonly IDatabase _redisDb;

    public override async Task<Result> SendVerificationCode(string phoneNumber)
    {
        RedisValue redisValue = _redisDb.StringGet(phoneNumber + "_time");
        if (redisValue.HasValue)
        {
            int seconds = (int)DateTime.UtcNow.Subtract(new DateTime((long)redisValue)).TotalSeconds;
            return new Result()
                { Data = null, ErrorMessages = new[] { "请勿频繁发送验证码，请在" + (int)(_messageSettings.SendCodeInterval.TotalSeconds - seconds) + "秒后重试" } };
        }

        const string code = "6666";
        _redisDb.StringSet(phoneNumber, code, _messageSettings.CodeExpireIn);
        _redisDb.StringSet(phoneNumber + "_time", DateTime.UtcNow.Ticks, _messageSettings.SendCodeInterval);

        //TODO: 发送短信

        return new Result() { Data = "验证码已发送" };
    }

    public override async Task<bool> VerifyCode(string phoneNumber, string code)
    {
        RedisValue redisValue = await _redisDb.StringGetAsync(phoneNumber);
        if (!redisValue.HasValue || redisValue.ToString() != code)
            return false;

        _redisDb.KeyDelete(phoneNumber);
        _redisDb.KeyDelete(phoneNumber + "_time");

        return true;
    }
}