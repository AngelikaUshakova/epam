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
    public class Customers : IEntityStore<Customer>
    {
        private SqlConnection connection;

        public Customers(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Customer customer)
        {
            string sql = string.Format("INSERT INTO Customers(Name,Address,Email," +
                "Phone,INN,CheckAcc,CorAcc,Bank,Bic) " +
                "Values(@name,@address,@email,@phone,@inn,@checkAcc,@corAcc," +
                "@bank,@bic)");
            using (var command = connection.CreateCommand())
            {

                command.CommandText = sql;
                {
                    command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 20));
                    command.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 20));
                    command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 30));
                    command.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@inn", SqlDbType.NVarChar, 20));
                    command.Parameters.Add(new SqlParameter("@checkAcc", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@corAcc", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@bank", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@bic", SqlDbType.NVarChar, 15));
                } //Add

                command.Prepare();
                {
                    command.Parameters[0].Value = customer.Name;
                    command.Parameters[1].Value = customer.Address;
                    command.Parameters[2].Value = customer.Email;
                    command.Parameters[3].Value = customer.Phone;
                    command.Parameters[4].Value = customer.Inn;
                    command.Parameters[5].Value = customer.CheckAcc;
                    command.Parameters[6].Value = customer.CorAcc;
                    command.Parameters[7].Value = customer.Bank;
                    command.Parameters[8].Value = customer.Bic;
                } //Value

                int result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Customers WHERE ID = '{0}'", id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            string sql = string.Format("SELECT * FROM Customers");
            using (var command = new SqlCommand())
            {
                command.CommandText = sql;
                command.Connection = connection;

                var a = command.ExecuteReader();

                while (a.Read())
                {
                    int id = a.GetInt32(0);
                    string name = a.GetString(1);
                    string address = a.GetString(2);
                    string email = a.GetString(3);
                    string phone = a.GetString(4);
                    string inn = a.GetString(5);
                    string checkAcc = a.GetString(6);
                    string corAcc = a.GetString(7);
                    string bank = a.GetString(8);
                    string bic = a.GetString(9);
                    customers.Add(new Customer(id, name, address, email, phone, inn,checkAcc,corAcc,bank,bic));
                }
                a.Close();
            }
            return customers;
        }

        public void Update(Customer customer)
        {
            string sql = string.Format("UPDATE Customers SET Name = '{0}',Address = '{1}'," +
                "Email = '{2}',Phone = '{3}' WHERE ID = '{4}'",customer.Name,
                customer.Address,customer.Email, customer.Phone,customer.Id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
    }
}
