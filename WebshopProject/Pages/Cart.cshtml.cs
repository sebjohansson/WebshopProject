using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebshopProject.Pages
{
    public class CartModel : PageModel
    {

        public IEnumerable<Models.Product> GetProducts { get; set; }
        public IEnumerable<Models.Product> Cart { get; set; }
        [BindProperty]
        public string Search { get; set; }

        public void OnGet()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            Cart = Data.CartManager.GetCart();
            
        }
        public void OnPost()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            if (Search != null)
            {
                string search = Search.ToLower();
                GetProducts = GetProducts.Where(m => m.title.ToLower().Contains(search));
            }



        }
    }
}
