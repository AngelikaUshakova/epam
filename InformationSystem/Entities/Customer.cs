using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public Customer(int id, string name, string address, string email,
            string phone, string inn, string checkAcc, string corAcc, string bank, 
            string bic)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Phone = phone;
            Inn = inn;
            CheckAcc = checkAcc;
            CorAcc = corAcc;
            Bank = bank;
            Bic = bic;
        }

        public int Id { get;}
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Inn { get; set; }
        public string CheckAcc { get; set; }
        public string CorAcc { get; set; }
        public string Bank { get; set; }
        public string Bic { get; set; }
    }
}
