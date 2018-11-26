using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.BLL
{
    public interface ILogic
    {
        List<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);

        List<OrderProduct> GetOrderProducts();
        void AddOrderProduct(OrderProduct orderProduct);
        void UpdateOrderProduct(OrderProduct orderProduct);

        List<Order> GetOrders();
        void AddOrder(Order order);
        void DeleteOrder(int id);
        void UpdateOrder(Order order);

        List<Product> GetProducts();
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);

        List<Service> GetServices();
        void AddService(Service service);
       // void DeleteCustomer(int id);
        //void UpdateCustomer(string name, int id);

        //List<Supplier> GetSuppliers();
    }
}
