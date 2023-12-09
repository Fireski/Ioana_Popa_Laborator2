using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ioana_Popa_Laborator2.Data;
using Ioana_Popa_Laborator2.Models;

namespace Ioana_Popa_Laborator2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Ioana_Popa_Laborator2.Data.Ioana_Popa_Laborator2Context _context;

        public IndexModel(Ioana_Popa_Laborator2.Data.Ioana_Popa_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
