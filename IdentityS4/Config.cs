using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityS4
{
    public class Config
    {
        //scopes define the resources in your system
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client{
                     ClientId = "mvc",
                     ClientName="MVC Client",
                     AllowedGrantTypes = GrantTypes.Implicit, //隐式方式
                     RequireConsent = true,  //如果不需要显示否同意授权 页面 这里就设置为false
                     RedirectUris ={ "https://localhost:5003/Index" },//登录成功后返回的客户端地址
                     PostLogoutRedirectUris = { "https://localhost:5003/Account"},///注销登录后返回的客户端地址

                     //下面这两个必须要加吧 不太明白啥意思
                     AllowedScopes =
                     {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                     }
                }
            };
        }
    }
}
