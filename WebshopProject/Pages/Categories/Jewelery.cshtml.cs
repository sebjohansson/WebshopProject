using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebshopProject.Pages.Categories
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Models.Product> GetProducts { get; set; }

        [BindProperty]
        public string Search { get; set; }
        public void OnGet()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            GetProducts = GetProducts.Where(m => m.category.ToLower().Contains("jewelery"));
        }
        public void OnPost()
        {
            GetProducts = (IEnumerable<Models.Product>)Data.ApiManager.GetProducts();
            GetProducts = GetProducts.Where(m => m.category.ToLower().Contains("jewelery"));
            if (Search != null)
            {
                string search = Search.ToLower();
                GetProducts = GetProducts.Where(m => m.title.ToLower().Contains(search));
            }
        }
    }
}
