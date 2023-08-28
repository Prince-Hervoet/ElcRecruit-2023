// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace identity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            { };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "client_b",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    //AccessToken过期时间(秒),默认为3600秒/1小时
                    AccessTokenLifetime = 3600,

                    //RefreshToken的最长生命周期
                    //AbsoluteRefreshTokenLifetime = 2592000,

                    //RefreshToken生命周期以秒为单位。默认为1296000秒
                    SlidingRefreshTokenLifetime = 2592000, //以秒为单位滑动刷新令牌的生命周期。

                    //刷新令牌时，将刷新RefreshToken的生命周期。RefreshToken的总生命周期不会超过AbsoluteRefreshTokenLifetime。
                    RefreshTokenExpiration = TokenExpiration.Sliding,

                    //AllowOfflineAccess 允许使用刷新令牌的方式来获取新的令牌
                    AllowOfflineAccess = true,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = { "Api" }
                }
            };
    }
}