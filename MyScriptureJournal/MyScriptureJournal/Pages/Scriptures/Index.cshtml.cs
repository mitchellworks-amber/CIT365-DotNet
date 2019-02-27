using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList ByBook { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedBook { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of the books.
            IQueryable<string> bookQuery = from m in _context.Books
                                           orderby m.Set
                                           select m.Book;

            var scriptures = from m in _context.Scriptures
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(SelectedBook))
            {
                scriptures = scriptures.Where(s => s.Book == SelectedBook);
            }
            
            ByBook = new SelectList(await bookQuery.ToListAsync());
            Scripture = await _context.Scriptures.ToListAsync();
        }
    }
}
