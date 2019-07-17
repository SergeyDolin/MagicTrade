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
    public class DetailsModel : PageModel
    {
        private readonly MagicTrade.Models.MagicTradeContext _context;

        public DetailsModel(MagicTrade.Models.MagicTradeContext context)
        {
            _context = context;
        }

        public Card Card { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Card = await _context.Card.FirstOrDefaultAsync(m => m.ID == id);

            if (Card == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
