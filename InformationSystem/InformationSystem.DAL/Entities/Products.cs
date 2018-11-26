using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.DAL
{
    class Products : IEntityStore<Product>
    {
        private SqlConnection connection;

        public Products(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Product product)
        {
            string sql = string.Format("INSERT INTO Products(Title,Price,LeadTime)" +
                " Values(@title,@price,@leadTime)");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = sql;

                {
                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 20));
                    command.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                    command.Parameters.Add(new SqlParameter("@leadTime", SqlDbType.Int));
                } //Add

                command.Prepare();

                {
                    command.Parameters[0].Value = product.Title;
                    command.Parameters[1].Value = product.Price;
                    command.Parameters[2].Value = product.LeadTime;
                } //Value

                int result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Products WHERE ID = '{0}'", id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        public List<Product> Get()
        {
            List<Product> product = new List<Product>();
            string sql = string.Format("SELECT * FROM Products");
            using (var command = new SqlCommand())
            {
                command.CommandText = sql;
                command.Connection = connection;

                var a = command.ExecuteReader();

                while (a.Read())
                {
                    int id = a.GetInt32(0);
                    string title = a.GetString(1);
                    decimal price = a.GetDecimal(2);
                    int leadTime = a.GetInt32(3);
                    product.Add(new Product(id, title, price, leadTime));
                }
                a.Close();
            }
            return product;
        }

        public void Update(Product product)
        {
            string sql = string.Format("UPDATE Products SET Title = '{0}',Price = '{1}'," +
                "LeadTime = '{2}' WHERE ID = '{3}'", product.Title,
                product.Price, product.LeadTime, product.Id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
    }
}
