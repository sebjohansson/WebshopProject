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
    public class DetailsModel : PageModel
    {
        private readonly WebshopProject.Data.ProductContext _context;

        public DetailsModel(WebshopProject.Data.ProductContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
