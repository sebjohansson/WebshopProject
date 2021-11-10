using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebshopProject.Data
{
    public class ApiManager
    {
        public static List<Models.Product> GetProducts()
        {
            var httpClient = new HttpClient();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var response = httpClient.GetAsync("https://fakestoreapi.com/products").GetAwaiter().GetResult();
            var apiResponse = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            return JsonSerializer.Deserialize<List<Models.Product>>(apiResponse);
        }
    }
}
