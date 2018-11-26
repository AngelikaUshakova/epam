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
    class OrderProducts : IEntityStore<OrderProduct>
    {
        private SqlConnection connection;

        public OrderProducts(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(OrderProduct orderProduct)
        {
            string sql = string.Format("INSERT INTO OrderProduct(IdOrder,IdProduct,Amount,Length,Width," +
                "TypeForm,IdService)" +
              " Values(@idOrder,@idProduct,@amount,@length,@width,@typeForm,@idService)");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = sql;

                {
                    command.Parameters.Add(new SqlParameter("@idOrder", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@idProduct", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@amount", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@length", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@width", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@typeForm", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@idService", SqlDbType.Int));

                } //Add

                command.Prepare();

                {
                    command.Parameters[0].Value = orderProduct.IdOrder;
                    command.Parameters[1].Value = orderProduct.IdProduct;
                    command.Parameters[2].Value = orderProduct.Amount;
                    command.Parameters[3].Value = orderProduct.Length;
                    command.Parameters[4].Value = orderProduct.Width;
                    command.Parameters[5].Value = orderProduct.TypeForm;
                    command.Parameters[6].Value = orderProduct.IdService;
                } //Value

                int result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> Get()
        {
            List<OrderProduct> orderProduct = new List<OrderProduct>();
            string sql = string.Format("SELECT * FROM OrderProduct");
            using (var command = new SqlCommand())
            {
                command.CommandText = sql;
                command.Connection = connection;

                var a = command.ExecuteReader();

                while (a.Read())
                {
                    int idOrder = a.GetInt32(0);
                    int idProduct = a.GetInt32(1);
                    int amount = a.GetInt32(2);
                    float length = (float)a.GetDouble(3);
                    float width = (float)a.GetDouble(4);
                    string typeForm = a.GetString(5);
                    int idService = a.GetInt32(6);
                    orderProduct.Add(new OrderProduct(idOrder,idProduct,amount,length,width,typeForm,idService));
                }
                a.Close();
            }
            return orderProduct;
        }

        public void Update(OrderProduct orderProduct)
        {
            
        }
    }
}
