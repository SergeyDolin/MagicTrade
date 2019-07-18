using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MagicTrade.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MagicTradeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MagicTradeContext>>()))
            {
                // Look for any movies.
                if (context.Card.Any())
                {
                    return;   // DB has been seeded
                }

                context.Card.AddRange(
                    new Card
                    {
                        Name = "Pit Scorpion",
                        Set = "Set 5",
                        Type = "Summon Scorpion",
                        Condition = "N",
                        Price = 0.15M,
                        Owner = "SergeyDolin@mail.ru"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
