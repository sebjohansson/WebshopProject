using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebshopProject.Pages.Categories
{
    public class MensModel : PageModel
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
            GetProducts = GetProducts.Where(m => m.category.ToLower().Contains("men's clothing"));
        }
        public void OnPost()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            GetProducts = GetProducts.Where(m => m.category.ToLower().Contains("men's clothing"));
            if (Search != null)
            {
                string search = Search.ToLower();
                GetProducts = GetProducts.Where(m => m.title.ToLower().Contains(search));
            }
        }
    }
}
