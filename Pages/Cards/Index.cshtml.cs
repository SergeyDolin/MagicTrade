using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MagicTrade.Models;

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

        public async Task OnGetAsync()
        {
            Card = await _context.Card.ToListAsync();
        }
    }
}
