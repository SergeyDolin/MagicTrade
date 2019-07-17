using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MagicTrade.Models
{
    public class MagicTradeContext : DbContext
    {
        public MagicTradeContext (DbContextOptions<MagicTradeContext> options)
            : base(options)
        {
        }

        public DbSet<MagicTrade.Models.Card> Card { get; set; }
    }
}
