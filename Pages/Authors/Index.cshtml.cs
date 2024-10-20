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
    public class IndexModel : PageModel
    {
        private readonly Dragos_Daria_Lab2.Data.Dragos_Daria_Lab2Context _context;

        public IndexModel(Dragos_Daria_Lab2.Data.Dragos_Daria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Authors = await _context.Authors.ToListAsync();
        }
    }
}
