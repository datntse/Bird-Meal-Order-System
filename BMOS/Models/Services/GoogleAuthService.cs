using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.PeopleService.v1;
using Google.Apis.Services;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text.Json.Nodes;

namespace BMOS.Models.Services
{
    public class GoogleAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public GoogleAuthService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<GoogleUserInfo> GetUserInfoAsync(string code)
        {
            var clientId = "733494164563-3udejeeopbq2b1ognt9sn7vr3qr4atm8.apps.googleusercontent.com";
            var clientSecret = "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";
            var redirectUri = "https://localhost:7262/Account/LoginWithGoogle";
            var tokenUrl = "https://accounts.google.com/o/oauth2/token";
            var authCode = code;
            var values = new Dictionary<string, string>
        {
            { "client_id", clientId },
            { "client_secret", clientSecret },
            { "redirect_uri", redirectUri },
            { "code", authCode },
            { "grant_type", "authorization_code" }
        };
            var content = new FormUrlEncodedContent(values);
            var response = await _httpClient.PostAsync(tokenUrl, content);

            var json = await response.Content.ReadAsStringAsync();
            var tokens = JsonConvert.DeserializeObject<GoogleToken>(json);



            var userInfoUrl = "https://www.googleapis.com/oauth2/v1/userinfo";
            var request = new HttpRequestMessage(HttpMethod.Get, userInfoUrl);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "access_token");
            response = await _httpClient.SendAsync(request);
            json = await response.Content.ReadAsStringAsync();
            var userInfo = JsonConvert.DeserializeObject<GoogleUserInfo>(json);
            

            var peopleService = new PeopleServiceService(new BaseClientService.Initializer
            {
                HttpClientInitializer = new UserCredential(new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets
                    {
                        ClientId = clientId,
                        ClientSecret = clientSecret,
                    },
                }), "user", new TokenResponse
                {
                    AccessToken = tokens.AccessToken,
                    ExpiresInSeconds = tokens.ExpiresIn,
                    RefreshToken = tokens.RefreshToken,
                }),
            });
            var person = await peopleService.People.Get("people/me").ExecuteAsync();
            userInfo.Email = person.EmailAddresses?.FirstOrDefault()?.Value;
            userInfo.UserName = person.Names?.FirstOrDefault()?.DisplayName;
            return userInfo;
        }
    }

    public class GoogleToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }

    public class GoogleUserInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string UserName { get; set; }
    }
}
