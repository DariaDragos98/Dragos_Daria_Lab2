using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dragos_Daria_Lab2.Data;
using Dragos_Daria_Lab2.Models;

namespace Dragos_Daria_Lab2.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Dragos_Daria_Lab2.Data.Dragos_Daria_Lab2Context _context;

        public DetailsModel(Dragos_Daria_Lab2.Data.Dragos_Daria_Lab2Context context)
        {
            _context = context;
        }

        public Authors Authors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
