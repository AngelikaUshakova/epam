using Entities;
using InformationSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.DAL
{
    public class AccessBD : IAccess
    {
        public IEntityStore<Customer> Customers { get; set; }
        public IEntityStore<Order> Orders { get; set; }
        public IEntityStore<OrderProduct> OrderProducts { get; set; }
        public IEntityStore<Product> Products { get; set; }
        public IEntityStore<Service> Services { get; set; }

        protected string connectionString;
        protected SqlConnection connection;

        public AccessBD(string connectionString)
        {
            this.connectionString = connectionString;
            InitConnection();
            Customers = new Customers(connection);
            OrderProducts = new OrderProducts(connection);
            Orders = new Orders(connection);
            Products = new Products(connection);
            Services = new Services(connection);
        }

        
        public void InitConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            connection.StateChange += ConnectionStateChange;
        }

        public void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        } 
        //public List<Supplier> GetSuppliers()
        //{
        //    List<Supplier> suppliers = new List<Supplier>();
        //    string sql = string.Format("SELECT * FROM Suppliers");

        //        using (var command = new SqlCommand())
        //        {
        //            command.CommandText = sql;
        //            command.Connection = connection;

        //            var a = command.ExecuteReader();

        //            while (a.Read())
        //            {
        //                int id = a.GetInt32(0);
        //                string name = a.GetString(1);
        //                string address = a.GetString(2);
        //                string email = a.GetString(3);
        //                string phone = a.GetString(4);
        //                suppliers.Add(new Supplier(id, name, address, email, phone));
        //            }
        //            a.Close();
        //    }
        //    return suppliers;
        //}

    }
}
