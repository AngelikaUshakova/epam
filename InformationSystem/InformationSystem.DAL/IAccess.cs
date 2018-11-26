using Entities;
using System.Collections.Generic;
using System.Data;

namespace InformationSystem.DAL
{
    public interface IAccess
    {
        IEntityStore<Customer> Customers { get; set; }
        IEntityStore<Order> Orders { get; set; }
        IEntityStore<OrderProduct> OrderProducts { get; set; }
        IEntityStore<Product> Products { get; set; }
        IEntityStore<Service> Services { get; set; }
    }
}
