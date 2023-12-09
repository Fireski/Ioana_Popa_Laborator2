﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ioana_Popa_Laborator2.Data;
using Ioana_Popa_Laborator2.Models;

namespace Ioana_Popa_Laborator2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Ioana_Popa_Laborator2.Data.Ioana_Popa_Laborator2Context _context;

        public CreateModel(Ioana_Popa_Laborator2.Data.Ioana_Popa_Laborator2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
