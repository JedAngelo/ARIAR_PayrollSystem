using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json;

namespace ARIAR_PayrollSystem.Helpers
{
    public static class HttpHelper
    {
        private static string apiBasicUri = "https://localhost:44376";
        public static async Task<T> PostAsync<T, U>(string url, U contentValue)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.BaseAddress = new Uri(apiBasicUri);
                var serializedContent = JsonConvert.SerializeObject(contentValue);
                Console.WriteLine("Serialized Content: " + serializedContent);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("AccessToken", "");
                httpClient.DefaultRequestHeaders.Add("secretKey", "");
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "");
                httpClient.Timeout = TimeSpan.FromMinutes(10);
                var result = await httpClient.PostAsync(url, content);
                result.EnsureSuccessStatusCode();
                if (result.StatusCode == HttpStatusCode.OK)
                {
                    string resultContentString = result.Content.ReadAsStringAsync().Result;

                    T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                    return resultContent;
                }
                else
                {
                    string resultContentString = await result.Content.ReadAsStringAsync();
                    T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                    return resultContent;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                T resultContent = JsonConvert.DeserializeObject<T>("");
                return resultContent;
            }
            finally
            {
                httpClient.Dispose();
            }


        }
        public static async Task<T> GetAsync<T>(string url)
        {

            var httpClient = new HttpClient();
            try
            {
                httpClient.BaseAddress = new Uri(apiBasicUri);
                httpClient.DefaultRequestHeaders.Add("AccessToken", "");
                httpClient.DefaultRequestHeaders.Add("secretKey", "");
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "");
                httpClient.Timeout = TimeSpan.FromMinutes(10);

                var result = await httpClient.GetAsync(url);

                result.EnsureSuccessStatusCode();

                string resultContentString = result.Content.ReadAsStringAsync().Result;
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                T resultContent = JsonConvert.DeserializeObject<T>("");
                return resultContent;
            }
            finally
            {
                httpClient.Dispose();
            }

        }
        public static async Task<T> DeleteAsync<T>(string url)
        {

            var httpClient = new HttpClient();
            try
            {
                httpClient.BaseAddress = new Uri(apiBasicUri);
                httpClient.DefaultRequestHeaders.Add("AccessToken", "");
                httpClient.DefaultRequestHeaders.Add("secretKey", "");
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", "");
                httpClient.Timeout = TimeSpan.FromMinutes(10);

                var result = await httpClient.DeleteAsync(url);

                result.EnsureSuccessStatusCode();

                string resultContentString = result.Content.ReadAsStringAsync().Result;
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                T resultContent = JsonConvert.DeserializeObject<T>("");
                return resultContent;
            }
            finally
            {
                httpClient.Dispose();
            }

        }

    }

}
