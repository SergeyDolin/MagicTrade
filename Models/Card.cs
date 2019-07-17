using System;
using System.ComponentModel.DataAnnotations;

namespace MagicTrade.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Set { get; set; }
        public string Type { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
    }
}
