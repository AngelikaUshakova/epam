using Entities;
using InformationSystem.BLL;
using InformationSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.BL
{
    public class Logic : ILogic
    {
        IAccess access;
        public Logic(IAccess access)
        {
            this.access = access;
        }

        public void AddCustomer(Customer customer)
        {
            access.Customers.Add(customer);
        }

        public void AddOrder(Order order)
        {
            access.Orders.Add(order);
        }

        public void AddOrderProduct(OrderProduct orderProduct)
        {
            access.OrderProducts.Add(orderProduct);
        }

        public void AddProduct(Product product)
        {
            access.Products.Add(product);
        }

        public void AddService(Service service)
        {
            access.Services.Add(service);
        }

        public void DeleteCustomer(int id)
        {
            access.Customers.Delete(id);
        }

        public void DeleteOrder(int id)
        {
            access.Orders.Delete(id);
        }

        public void DeleteProduct(int id)
        {
            access.Products.Delete(id);
        }

        public List<Customer> GetCustomers()
        {
            return access.Customers.Get();
        }

        public List<OrderProduct> GetOrderProducts()
        {
            return access.OrderProducts.Get();
        }

        public List<Order> GetOrders()
        {
            return access.Orders.Get();
        }

        public List<Product> GetProducts()
        {
            return access.Products.Get();
        }

        public List<Service> GetServices()
        {
            return access.Services.Get();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderProduct(OrderProduct orderProduct)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            access.Products.Update(product);
        }

        //public List<Supplier> GetSuppliers()
        //{
        //    return access.GetSuppliers();
        //}

        //public void UpdateCustomer(string name, int id)
        //{
        //    access.UpdateCustomer(name, id);
        //}
    }
}
