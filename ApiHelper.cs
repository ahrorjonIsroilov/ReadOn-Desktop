using RestSharp;
using System.Net.Http;
using System.Net.Http.Headers;
namespace ReadCat
{
    public static class ApiHelper
    {
        public static string baseUri = "http://localhost:8090/api/v1/";
        public static HttpClient apiClient { get; set; }
        public static RestClient restClient { get; set; }
        public static void initializeClient()
        {
            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            restClient = new RestClient();
            restClient.AddDefaultHeader("Content-Type", "application/json");
        }
    }
}
