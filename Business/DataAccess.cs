using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS; database=E-TEACHER_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void Query(string sql)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
        }

        public void Read()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Insert()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setParameter(string key, object value)
        {
            command.Parameters.AddWithValue(key, value);
        }

        public void closeConnection()
        {
            try
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection != null && connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }
        public T GetScalarValue<T>()
        {
            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return (T)Convert.ChangeType(result, typeof(T));
            }
            else
            {
                throw new InvalidOperationException("Scalar value is null or DBNull.");
            }
        }
    }
}
