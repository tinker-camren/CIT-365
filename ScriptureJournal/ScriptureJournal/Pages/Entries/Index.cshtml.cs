using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Models.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Models.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentSort { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }
        public IList<Entry> Entries { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            IQueryable<string> bookQuery = from b in _context.Entry
                                            orderby b.Book
                                            select b.Book;

            var entries = from e in _context.Entry
                         select e;
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchString) || s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                entries = entries.Where(b => b.Book == ScriptureBook);
            }

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";


            switch (sortOrder)
            {
                case "name_desc":
                    entries = entries.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    entries = entries.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    entries = entries.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    entries = entries.OrderBy(s => s.Book);
                    break;
            }


            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            Entry = await entries.ToListAsync();

            //Entry = await _context.Entry.ToListAsync();
        }
        /*public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Entry> LQEntries = from e in _context.Entry
                                             select e;

            switch (sortOrder)
            {
                case "name_desc":
                    LQEntries = LQEntries.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    LQEntries = LQEntries.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    LQEntries = LQEntries.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    LQEntries = LQEntries.OrderBy(s => s.Book);
                    break;
            }

            Entries = await LQEntries.AsNoTracking().ToListAsync();
        } */
    }
}
