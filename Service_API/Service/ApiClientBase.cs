using Newtonsoft.Json;
using Service_API.Interface.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Service_API.Service
{
    public class ApiClientBase : IApiClient
    {
        private readonly string _token = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        public IApiResponse<TResult> ExecutaPost<TResult, TModel>(string relativePath, TModel ModelApi)
        {
            using (var client = new HttpClient())
            {
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                    client.Timeout = TimeSpan.FromMinutes(5);
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }

                var content = new StringContent(JsonConvert.SerializeObject(ModelApi),
                                                Encoding.UTF8,
                                                "application/json");

                var response = new ApiResponse<TResult>(client.PostAsync(relativePath, content).Result);

                if (!response.Success)
                {
                    if (response.isValidationError)
                        throw new ApplicationException(string.Join(Environment.NewLine, response.Errors));
                    else
                        throw new Exception(string.Join(Environment.NewLine, "There was a failure during the process.please contact technical support!"));
                }

                return response;
            }
        }
        public void ExecutaPostNoResult<TModel>(string relativePath, TModel ModelApi)
        {
            using (var client = new HttpClient())
            {
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                    client.Timeout = TimeSpan.FromMinutes(5);
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }

                var content = new StringContent(JsonConvert.SerializeObject(ModelApi),
                                                Encoding.UTF8,
                                                "application/json");


                HttpResponseMessage response = client.PostAsync(relativePath, content).Result;
                response.EnsureSuccessStatusCode();


            }
        }
        public void ExecutaPutNoResult<TModel>(string relativePath, TModel ModelApi)
        {
            using (var client = new HttpClient())
            {
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                    client.Timeout = TimeSpan.FromMinutes(5);
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }

                var content = new StringContent(JsonConvert.SerializeObject(ModelApi),
                                                Encoding.UTF8,
                                                "application/json");


                HttpResponseMessage response = client.PutAsync(relativePath, content).Result;
                response.EnsureSuccessStatusCode();


            }
        }
        public void ExecutaDeleteNoResult(string relativePath)
        {
            using (var client = new HttpClient())
            {
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                    client.Timeout = TimeSpan.FromMinutes(5);
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }

                HttpResponseMessage response = client.DeleteAsync(relativePath).Result;
                response.EnsureSuccessStatusCode();
            }
        }
        public IApiResponse<TResult> ExecutaPostNoParam<TResult>(string relativePath)
        {
            using (var client = new HttpClient())
            {
                if (client.BaseAddress == null)
                {
                    client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                    client.Timeout = TimeSpan.FromMinutes(5);
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }

                var response = new ApiResponse<TResult>(client.PostAsync(relativePath, null).Result);

                if (!response.Success)
                    throw new Exception(string.Join(Environment.NewLine, response.Errors));

                return response;
            }
        }
        public IApiResponse<TResult> ExecutaGetNoParam<TResult>(string relativePath)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    if (client.BaseAddress == null)
                    {
                        client.BaseAddress = new Uri(@"https://gorest.co.in/public-api/");
                        client.Timeout = TimeSpan.FromMinutes(5);
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                    }
                    var response = new ApiResponse<TResult>(client.GetAsync(relativePath).Result);

                    if (!response.Success)
                        throw new Exception(string.Join(Environment.NewLine, response.Errors));

                    return response;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

    }
}
