using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebshopProject.Data;
using WebshopProject.Models;

namespace WebshopProject.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly WebshopProject.Data.ProductContext _context;

        public IndexModel(WebshopProject.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {         
            Product = await _context.Product.ToListAsync();
        }
    }
}
