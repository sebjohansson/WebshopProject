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
        public IEnumerable<Models.Product> Cart { get; set; }
        [BindProperty]
        public string Search { get; set; }

        public void OnGet(int productId)
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            Cart = Data.CartManager.GetCart();
            if (productId != 0)
            {
                var product = GetProducts.Where(m => m.id == productId).FirstOrDefault();
                Data.CartManager.AddCart(product);
            }
        }
        public void OnPost(int productId)
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            if(Search != null)
            {
                string search = Search.ToLower();
                GetProducts = GetProducts.Where(m => m.title.ToLower().Contains(search));
            }

            if (productId != 0)
            {
                var product = GetProducts.Where(m => m.id == productId).FirstOrDefault();
                Data.CartManager.AddCart(product);
            }

        }
    }
}
