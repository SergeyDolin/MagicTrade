using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicTrade.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Set { get; set; }
        public string Type { get; set; }
        public string Condition { get; set; }
        [Column(TypeName = "decimal(18, 2)") ]
        public decimal Price { get; set; }
        public string Owner { get; set; }
    }
}
