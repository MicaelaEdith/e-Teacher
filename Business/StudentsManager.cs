using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Business
{
    public class StudentsManager
    {
        public List<Student> ListStudents()
        {

            List<Student> listStudents = new List<Student>();
            DataAccess data = new DataAccess();

            try
            {
                data.Query("Select id,nombre, apellido from alumnos;");
                data.Read();

                while (data.Reader.Read())
                {
                    Student aux = new Student();

                    aux.Id = (int)data.Reader["id"];
                    aux.Name = (string)data.Reader["nombre"];
                    aux.LastName = (string)data.Reader["apellido"];
             
                    listStudents.Add(aux);
                }
                return listStudents;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.closeConnection();
            }
        }

        public void AddStudent(Student s)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.Query("insert into alumnos (nombre, apellido, activo) values ('" + s.Name + "','" + s.LastName + "',1);");
                data.Insert();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                data.closeConnection();
            }

        }

        public void Delete(int id)
        {

            DataAccess data = new DataAccess();
            try
            {
                data.Query("update alumnos set activo = 0 where id = "+id);
                data.Insert();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                data.closeConnection();
            }

        }
    }
}
