using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InformationSystem.DAL
{
    class Orders : IEntityStore<Order>
    {
        private SqlConnection connection;

        public Orders(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Order order)
        {
           string sql = string.Format("INSERT INTO Orders(IdCustomers,DateOrder," +
                "DateDeparture,Delivery,Status) Values(@idCustomers,@dateOrder," +
                "@dateDeparture,@delivery,@status)");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = sql;

                {
                    command.Parameters.Add(new SqlParameter("@idCustomers", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@dateOrder", SqlDbType.DateTime2,10));
                    command.Parameters.Add(new SqlParameter("@dateDeparture", SqlDbType.DateTime2,10));
                    command.Parameters.Add(new SqlParameter("@delivery", SqlDbType.NVarChar, 100));
                    command.Parameters.Add(new SqlParameter("@status", SqlDbType.NVarChar, 20));
                } //Add

                command.Prepare();

                {
                    command.Parameters[0].Value = order.IdCustomer;
                    command.Parameters[1].Value = order.DateOrder;
                    command.Parameters[2].Value = order.DateDeparture;
                    command.Parameters[3].Value = order.Delivery;
                    command.Parameters[4].Value = order.Status;

                } //Value

                int result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string sql = string.Format("DELETE FROM Orders WHERE ID = '{0}'", id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }

        public List<Order> Get()
        {
            List<Order> order = new List<Order>();
            string sql = string.Format("SELECT * FROM Orders");
            using (var command = new SqlCommand())
            {
                command.CommandText = sql;
                command.Connection = connection;

                var a = command.ExecuteReader();

                while (a.Read())
                {
                    int id = a.GetInt32(0);
                    int idCistomers = a.GetInt32(1);
                    DateTime dateOrder = a.GetDateTime(2);
                    DateTime dateDepsrture = a.GetDateTime(3);
                    string delivery = a.GetString(4);
                    string status = a.GetString(5);
                    order.Add(new Order(id, idCistomers, dateOrder, dateDepsrture, delivery,status));
                }
                a.Close();
            }
            return order;
        }

        public void Update(Order order)
        {
            string sql = string.Format("UPDATE Orders SET IdCustomer = '{0}',DateOrder = '{1}'," +
                  "DateDeparture = '{2}',Delivery = '{3}', Status = '{4}'  WHERE ID = '{5}'",order.IdCustomer,
                  order.DateOrder, order.DateDeparture,order.Delivery,order.Status,order.Id);
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
        }
    }
}
