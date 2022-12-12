using System.Collections.Generic;
using System.Linq;
using Xunit;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using AutomationWebApp.ApiModels;
using AutomationWebApp.Utils;
using System.Net.Http.Headers;

namespace AutomationWebApp.TestCases
{
    public class APItest
    {
        public const string API_URI_BASE = "https://production-qa-fxhcwcz4ja-ew.a.run.app/swagger/index.html";

        [Fact]
        public async void VerifyUserLoginResponse()
        {
            string url = API_URI_BASE + "#/account/post_account_login";
            var reqObject = new User();
            reqObject.email = "emiliseremet@gmail.com";
            reqObject.password = "Test2022!!";
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Dictionary<string, string> dictionary = reqObject.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(reqObject)?.ToString() ?? "");
            var content = new FormUrlEncodedContent(dictionary);
            var response = await client.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            //Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        }
    }
}
