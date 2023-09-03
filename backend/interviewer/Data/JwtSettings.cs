using Microsoft.Extensions.Configuration;

namespace interviewer.Data
{
    public class JwtSettings
    {
        public required string SecurityKey{ get; set; }
        public TimeSpan ExpiresIn { get; set; }
    }
}
