﻿namespace Microsoft.AspNetCore.Authentication.Weixin
{
    /// <summary>
    /// Contains constants specific to the <see cref="WeixinAuthenticationHandler"/>.
    /// </summary>
    public static class WeixinAuthenticationConstants
    {
        public static class Claims
        {
            public const string City = "urn:weixin:city";
            public const string HeadImgUrl = "urn:weixin:headimgurl";
            public const string OpenId = "urn:weixin:openid";
            public const string Privilege = "urn:weixin:privilege";
            public const string Province = "urn:weixin:province";
        }
    }

    /// <summary>
    /// Default values for Weixin authentication.
    /// </summary>
    public static class WeixinAuthenticationDefaults
    {
        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.Name"/>.
        /// </summary>
        public const string AuthenticationScheme = "Weixin";

        /// <summary>
        /// Default value for <see cref="AuthenticationScheme.DisplayName"/>.
        /// </summary>
        public const string DisplayName = "Weixin";

        /// <summary>
        /// Default value for <see cref="RemoteAuthenticationOptions.CallbackPath"/>.
        /// </summary>
        public const string CallbackPath = "/signin-weixin";

        /// <summary>
        /// Default value for <see cref="AuthenticationSchemeOptions.ClaimsIssuer"/>.
        /// </summary>
        public const string Issuer = "Weixin";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.AuthorizationEndpoint"/>.
        /// </summary>
        public const string AuthorizationEndpoint = "https://open.weixin.qq.com/connect/qrconnect";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.TokenEndpoint"/>.
        /// </summary>
        public const string TokenEndpoint = "https://api.weixin.qq.com/sns/oauth2/access_token";

        /// <summary>
        /// Default value for <see cref="OAuthOptions.UserInformationEndpoint"/>.
        /// </summary>
        public const string UserInformationEndpoint = "https://api.weixin.qq.com/sns/userinfo";
    }
}