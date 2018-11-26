using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public Order(int id, int idCustomer, DateTime dateOrder, 
            DateTime dateDeparture, string delivery, string status)
        {
            Id = id;
            IdCustomer = idCustomer;
            DateOrder = dateOrder;
            DateDeparture = dateDeparture;
            Delivery = delivery;
            Status = status;
        }

        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime DateDeparture { get; set; }
        public string Delivery { get; set; }
        public string Status { get; set; }
    }
}
