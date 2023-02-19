using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scrpitures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public SelectList Entry { get; private set; }
        public IList<Scripture> Scripture { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ScriptureBook { get; set; }
        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            BookSort = sortOrder == "Book" ? "book_desc" : "Book";

            // Use LINQ to get list of books.
            IQueryable<string> bookQuery = from s in _context.Scriptures
                                            orderby s.Book
                                            select s.Book;

            var scriptures = from m in _context.Scriptures
                             select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Entry.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }

            //switch case for sorting
            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
                case "Book":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.EntryDate);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.EntryDate);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Id);
                    break;
            }

            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
            Scripture = await scriptures.ToListAsync();
        }
    }
}
