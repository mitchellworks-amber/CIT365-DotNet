using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class EditModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public EditModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Scripture Scripture { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BySet { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedSet { get; set; }
        public SelectList ByBook { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedBook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Scripture = await _context.Scriptures.FirstOrDefaultAsync(m => m.ID == id);

            // Use LINQ to get list of the books.
            IQueryable<string> setQuery = from m in _context.Books
                                          orderby m.Set
                                          select m.Set;
            BySet = new SelectList(await setQuery.Distinct().ToListAsync(), Scripture.Set);
            IQueryable<string> bookQuery = from m in _context.Books
                                           orderby m.Set
                                           select m.Book;
            ByBook = new SelectList(await bookQuery.ToListAsync(), Scripture.Book);


            if (Scripture == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Scripture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScripturesExists(Scripture.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScripturesExists(int id)
        {
            return _context.Scriptures.Any(e => e.ID == id);
        }
    }
}
