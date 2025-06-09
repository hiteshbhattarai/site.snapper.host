using Duende.IdentityServer.Models;

namespace site.snapper.iam.host
{
    public static class Config
    {
        public static List<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
            };



        public static List<ApiResource> ApiScopes =>
            new List<ApiResource>
            {
                new ApiResource("admin-identity","Openid Access",["time_zone"]){
                 Scopes = new List<string>{
                     "identity.resources.full_access",
                     "api.resources.full_access",
                     "client.resources.full_access"
                 },
                 UserClaims = new List<string>{
                     "time_zone"
                 }

                    },
                new ApiResource("ss-images","Site Snapper Images",["time_zone"]){
                 Scopes = new List<string>{
                     "snapper.images.full_access"
                 },
                 UserClaims = new List<string>{
                     "time_zone"
                 }

                    }
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
               
                // interactive client using code flow + pkce
                new Client
                {
                    ClientId = "sitesnapper-web-client",
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44300/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "ss-images" },

                },
            };
    }
}
