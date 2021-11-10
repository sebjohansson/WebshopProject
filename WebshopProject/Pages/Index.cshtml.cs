using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebshopProject.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Models.Product> GetProducts { get; set; }
        public void OnGet()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
        }
    }
}
