using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Supplier
    {
        public Supplier(int id, string name, string address, string email,
            string phone)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
        }

        public int Id { get;}
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
