using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BySet { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedSet { get; set; }
        public SelectList ByBook { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedBook { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of the books.
            IQueryable<string> setQuery = from m in _context.Books
                                           orderby m.Set
                                           select m.Set;
            BySet = new SelectList(await setQuery.Distinct().ToListAsync());
            IQueryable<string> bookQuery = from m in _context.Books
                                           orderby m.Set
                                           select m.Book;
            ByBook = new SelectList(await bookQuery.ToListAsync());
            //return Page();
        }

        [BindProperty]
        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Scriptures.Add(Scripture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}