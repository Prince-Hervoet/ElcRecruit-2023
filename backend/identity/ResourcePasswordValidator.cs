using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;

namespace identity
{
    public class ResourcePasswordValidator : IResourceOwnerPasswordValidator
    {
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            //判断账号密码是否正确。
            if (context.UserName == "userName" && context.Password == "1234567")
            {
                context.Result = new GrantValidationResult(
                    subject: "userInfo",
                    authenticationMethod: OidcConstants.AuthenticationMethods.Password,
                    claims: GetUserClaims());
            }
            else
            {
                //验证失败
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "invalid custom credential");
            }
        }

        //可以根据需要设置相应的Claim/需要实现IProfileService接口
        private Claim[] GetUserClaims()
        {

            return new Claim[]
            {
                new Claim("userId","110"),
                new Claim(JwtClaimTypes.Name,"林辉"),
                new Claim(JwtClaimTypes.Role,"菜鸡")
            };
        }
    }
}
