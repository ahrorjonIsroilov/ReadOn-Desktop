using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using ReadCat.Payloads;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static ReadCat.ApiHelper;

namespace ReadCat
{
    public class AuthService
    {
        public async Task<ApiResponse> register(RegisterDto dto)
        {
            try
            {
                String url = baseUri + "auth/register";
                HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
                ApiResponse response = await apiClient.PostAsync(url, content).Result.Content.ReadAsAsync<ApiResponse>();
                return response;
            }
            catch (Exception ex)
            {
                return new ApiResponse()
                {
                    message = ex.Message,
                    success = false
                };
            }
        }

        public async Task<ApiResponse> login(LoginDto dto)
        {
            try
            {
                String url = baseUri + "auth/login";
                HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
                return await apiClient.PostAsync(url, content).Result.Content.ReadAsAsync<ApiResponse>();
            }
            catch (Exception ex)
            {
                return new ApiResponse()
                {
                    message = ex.Message,
                    success = false
                };
            }
        }

        /// <summary>
        /// Get request with RestSharp Client
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<ApiResponse> forgotPassword(String email)
        {
            try
            {
                String url = baseUri + "auth/forgotPassword";
                var endpoint = QueryHelpers.AddQueryString(url, new Dictionary<string, string>()
                {
                    ["email"] = email,
                });
                return await apiClient.GetAsync(endpoint).Result.Content.ReadAsAsync<ApiResponse>();
            }
            catch (Exception ex)
            {
                return new ApiResponse()
                {
                    message = ex.Message,
                    success = false
                };
            }
        }

        public async Task<ApiResponse> resendCode(String email)
        {
            try
            {
                string url = baseUri + "auth/resendResetPassword";
                var request = new RestRequest(url);
                request.AddParameter("email", email);
                return await restClient.GetAsync<ApiResponse>(request);
            }
            catch
            {
                return new ApiResponse()
                {
                    message = "Something went wrong!",
                    success = false
                };
            }
        }

        public async Task<ApiResponse> resetPassword(PasswordResetDto dto)
        {
            try
            {
                String url = baseUri + "auth/resetPassword";
                HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
                return await apiClient.PostAsync(url,content).Result.Content.ReadAsAsync<ApiResponse>();
            }
            catch (Exception ex)
            {
                return new ApiResponse()
                {
                    message = ex.Message,
                    success = false
                };
            }
        }
    }
}
