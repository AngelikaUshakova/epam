using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Service
    {
        public Service(int id, string title, string type, decimal price, int leadTime)
        {
            Id = id;
            Title = title;
            Type = type;
            Price = price;
            LeadTime = leadTime;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int LeadTime { get; set; }
    }
}
