using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebshopProject.Pages
{
    public class CheckoutModel : PageModel
    {
        public IEnumerable<Models.Product> Cart { get; set; }
        public void OnGet()
        {
            Cart = Data.CartManager.GetCart();
        }
    }
}
