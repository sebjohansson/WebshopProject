using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [BindProperty]
        public string Search { get; set; }
        public void OnGet()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
        }
        public void OnPost()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            if(Search != null)
            {
                string search = Search.ToLower();
                GetProducts = GetProducts.Where(m => m.title.ToLower().Contains(search));
            }
          
        }
    }
}
