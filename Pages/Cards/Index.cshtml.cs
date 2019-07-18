using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagicTrade.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagicTrade.Pages.Cards
{
    public class IndexModel : PageModel
    {
        private readonly MagicTrade.Models.MagicTradeContext _context;

        public IndexModel(MagicTrade.Models.MagicTradeContext context)
        {
            _context = context;
        }

        public IList<Card> Card { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet =true)]
        public string CardSet { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> setQuery = from m in _context.Card
                                            orderby m.Set
                                            select m.Set;

            var cards = from m in _context.Card
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                cards = cards.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CardSet))
            {
                cards = cards.Where(x => x.Set == CardSet);
            }
            Name = new SelectList(await setQuery.Distinct().ToListAsync());
            Card = await cards.ToListAsync();
        }
    }
}
