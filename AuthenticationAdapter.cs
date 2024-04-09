using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Qwips.SemineSync.ClientSdk.Authentication
{
    public static class AuthenticationAdapter
    {
        /*
        public static async Task<AccessTokenDto> GetToken(string tokenUrl, string userName, string passWord, string scope = "invoiceservice", string grantType = "password")
        {
            
            var tokenUrl = "https://smartservice/token";
            var clientId = "semine";
            var clientSecret = "Dqz8q8tMm3BrTKkzfRSJ";
            
            string encodedBasicAuth = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1")
                               .GetBytes(clientId + ":" + clientSecret));
            var uri = new Uri(tokenUrl);
            var client = new RestClient($"{uri.Scheme}://{uri.Host}");
            var request = new RestRequest(uri.AbsolutePath,Method.Post);
            request.AddHeader("authorization", "basic " + encodedBasicAuth);
            request.AddParameter("grant_type", grantType);
            request.AddParameter("password", passWord);
            request.AddParameter("scope", scope);
            request.AddParameter("username", userName);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var token = JsonConvert.DeserializeObject<AccessTokenDto>(response.Content);

                return token;
            }
            else
            {
                throw new Exception(response.Content);
            }
        }

        public class AccessTokenDto
        {
            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }
            [JsonProperty("token_type")]
            public string TokenType { get; set; }
            [JsonProperty("scope")]
            public string Scope { get; set; }
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }

        }*/
    }
}
