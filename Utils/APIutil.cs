using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationWebApp.ApiModels; 
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace AutomationWebApp.Utils
{
   static class APIutil
    {

        public static string GetRandomString()
        {
            var chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            var output = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                output.Append(chars[random.Next(chars.Length)]);
            }

            return output.ToString();
        }

        //public static async Task<TokenResponse> LogUser(string url, string username, string password)
        //{
        //    var reqObject = new User();
        //    reqObject.username = username;
        //    reqObject.password = password;
        //    HttpClient client = new HttpClient();
        //    client.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    Dictionary<string, string> dictionary = reqObject.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(reqObject)?.ToString() ?? "");
        //    var content = new FormUrlEncodedContent(dictionary);
        //    var response = await client.PostAsync(url, content);
        //    var responseString = await response.Content.ReadAsStringAsync();
        //    return JsonConvert.DeserializeObject<TokenResponse>(responseString);
        //}
    }
}
