using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.DAL.Entities
{
    class Services : IEntityStore<Service>
    {
        private SqlConnection connection;

        public Services(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Service service)
        {
            string sql = string.Format("INSERT INTO Services(Id,Title,Type,Price,LeadTime)" +
              " Values(@id,@title,@type,@price,@leadTime");
            using (var command = connection.CreateCommand())
            {
                command.CommandText = sql;

                {
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@title", SqlDbType.NVarChar, 20));
                    command.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar, 15));
                    command.Parameters.Add(new SqlParameter("@price", SqlDbType.Money));
                    command.Parameters.Add(new SqlParameter("@leadTime", SqlDbType.Int));
                } //Add

                command.Prepare();

                {
                    command.Parameters[0].Value = service.Id;
                    command.Parameters[1].Value = service.Title;
                    command.Parameters[2].Value = service.Type;
                    command.Parameters[3].Value = service.Price;
                    command.Parameters[4].Value = service.LeadTime;
                } //Value

                int result = command.ExecuteNonQuery();
            }
        }

        public void Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public List<Service> Get()
        {
            List<Service> service = new List<Service>();
            string sql = string.Format("SELECT * FROM Services");
            using (var command = new SqlCommand())
            {
                command.CommandText = sql;
                command.Connection = connection;

                var a = command.ExecuteReader();

                while (a.Read())
                {
                    int id = a.GetInt32(0);
                    string title = a.GetString(1);
                    string type = a.GetString(2);
                    decimal price = a.GetDecimal(3);
                    int leadTime = a.GetInt32(4);
                    service.Add(new Service(id, title,type,price,leadTime));
                }
                a.Close();
            }
            return service;
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }
    }
}
