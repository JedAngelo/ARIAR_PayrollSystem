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
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PayrollSystem.Forms.Modals;
using PayrollSystem.Models;

namespace PayrollSystem.Helpers
{
    public static class HttpHelper
    {
        private static string _apiBasicUri = UriHelper.LoadUri().Uri;
        //private static string _apiBasicUri = "http://localhost:2410";
        //private static string _apiBasicUri = "http://localhost:2450";


        private static string accessToken;  // Store the access token
        private static readonly string secretKey = "TheTreesMightLongForPeaceButTheWindWillNeverCeaseTheQuickBrownFoxJumpsOverTheLazyDog";

        public static string AccessToken
        {
            get { return accessToken; }
            private set { accessToken = value; }
        }

        public static UserLoginDto UserData { get; set; }

        public static void DeleteAccessToken()
        {
            if (accessToken != null) accessToken = null;
        }

        public static void SetAccessToken(string token)
        {

            if (accessToken == null)
            {
                accessToken = token;
            }
            else
            {
                throw new InvalidOperationException("Access token has already been set and cannot be modified.");
            }
        }

        // Method to set the access token after login
        //public static void SetAccessToken(string token)
        //{
        //    accessToken = token;
        //}

        public static string GetAccessToken()
        {
            return accessToken;
        }

        public static async Task<T> PostAsync<T, U>(string url, U contentValue)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.BaseAddress = new Uri(_apiBasicUri);
                var serializedContent = JsonConvert.SerializeObject(contentValue);
                Console.WriteLine(JsonConvert.SerializeObject(contentValue, Formatting.Indented));
                Console.WriteLine("Serialized Content: " + serializedContent);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("AccessToken", accessToken);
                httpClient.DefaultRequestHeaders.Add("secretKey", secretKey);
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);
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

        public static async Task<T> PostAsync2<T, U>(string url, U contentValue)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.BaseAddress = new Uri(_apiBasicUri);
                var serializedContent = JsonConvert.SerializeObject(contentValue);
                Console.WriteLine(JsonConvert.SerializeObject(contentValue, Formatting.Indented));
                Console.WriteLine("Serialized Content: " + serializedContent);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                httpClient.DefaultRequestHeaders.Add("AccessToken", accessToken);
                httpClient.DefaultRequestHeaders.Add("secretKey", secretKey);
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);
                httpClient.Timeout = TimeSpan.FromMinutes(10);
                var result = await httpClient.PostAsync(url, content);
                result.EnsureSuccessStatusCode();

                string resultContentString = await result.Content.ReadAsStringAsync();


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

        public static async Task<T> GetAsync<T>(string url)
        {

            var httpClient = new HttpClient();
            try
            {
                httpClient.BaseAddress = new Uri(_apiBasicUri);
                httpClient.DefaultRequestHeaders.Add("AccessToken", accessToken);
                httpClient.DefaultRequestHeaders.Add("secretKey", secretKey);
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);
                httpClient.Timeout = TimeSpan.FromMinutes(10);

                //test log
                string fullUrl = new Uri(httpClient.BaseAddress, url).ToString();
                Console.WriteLine($"Request URL: {fullUrl}");

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
                httpClient.BaseAddress = new Uri(_apiBasicUri);
                httpClient.DefaultRequestHeaders.Add("AccessToken", accessToken);
                httpClient.DefaultRequestHeaders.Add("secretKey", secretKey);
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);
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

        public static async Task<T> PutAsync<T, U>(string url, U contentValue)
        {
            var httpClient = new HttpClient();

            try
            {
                httpClient.BaseAddress = new Uri(_apiBasicUri);
                var serializedContent = JsonConvert.SerializeObject(contentValue);
                Console.WriteLine(JsonConvert.SerializeObject(contentValue, Formatting.Indented));
                Console.WriteLine("Serialized Content: " + serializedContent);
                var content = new StringContent(serializedContent, Encoding.UTF8, "application/json");

                httpClient.DefaultRequestHeaders.Add("AccessToken", accessToken);
                httpClient.DefaultRequestHeaders.Add("secretKey", secretKey);
                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", accessToken);
                httpClient.Timeout = TimeSpan.FromMinutes(10);

                // Log the full request URL for debugging
                string fullUrl = new Uri(httpClient.BaseAddress, url).ToString();
                Console.WriteLine($"Request URL: {fullUrl}");

                var result = await httpClient.PutAsync(url, content);

                result.EnsureSuccessStatusCode();

                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in PutAsync: {ex.Message}");
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
