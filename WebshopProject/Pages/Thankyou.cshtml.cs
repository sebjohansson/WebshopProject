using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebshopProject.Data;

namespace WebshopProject.Pages
{
    public class ThankyouModel : PageModel
    {
        public void OnGet()
        {
            CartManager.Cart.Clear();
        }
    }
}

