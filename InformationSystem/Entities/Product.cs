using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public Product(int id, string title, decimal price, int leadTime)
        {
            Id = id;
            Title = title;
            Price = price;
            LeadTime = leadTime;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int LeadTime { get; set; }   
    }
}
