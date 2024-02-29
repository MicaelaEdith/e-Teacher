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

        public List<Student> ListStudentsAvailable()
        {

            List<Student> listStudents = new List<Student>();
            DataAccess data = new DataAccess();

            try
            {
                data.Query("Select id,nombre, apellido, activo from alumnos where activo=1;");
                data.Read();

                while (data.Reader.Read())
                {
                    Student aux = new Student();

                    aux.Id = (int)data.Reader["id"];
                    aux.Name = (string)data.Reader["nombre"];
                    aux.LastName = (string)data.Reader["apellido"];
                    aux.available = (bool)data.Reader["activo"];

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

        public string findNameByid(int id)
        {
            string name = "";

            DataAccess data = new DataAccess();
            try
            {
                data.Query("Select nombre, apellido from alumnos where id=" + id);
                data.Read();

                while (data.Reader.Read())
                {
                    name = (string)data.Reader["nombre"] + " " + (string)data.Reader["apellido"];
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                data.closeConnection();
            }

            return name;
        }

        public void AddStudent(string name, string lastName)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.Query("insert into alumnos values ('" + name + "','" + lastName + "',1)");
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
                data.Query("update alumnos set activo = 0 where id = " + id);
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

        public Student findByid(int idValue)
        {
            Student s = new Student();
            DataAccess data = new DataAccess();
            try
            {
                data.Query("Select nombre, apellido, activo from alumnos where id=" + idValue);
                data.Read();

                while (data.Reader.Read())
                {
                    s.Id = idValue;
                    s.Name = (string)data.Reader["nombre"];
                    s.LastName = (string)data.Reader["apellido"];
                    s.available = (bool)data.Reader["activo"];
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                data.closeConnection();
            }

            return s;
        }

        public void Update(Student s)
        {

            DataAccess data = new DataAccess();
            try
            {
                data.Query("update alumnos set nombre='" + s.Name + "', apellido = '" + s.LastName + "' where id = " + s.Id);
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

        public void AddCourse(int idStudent, int idCourse) {

            DataAccess data = new DataAccess();
            try
            {
                
                data.Query("INSERT INTO cursos_alumnos (curso, alumno) VALUES ("+idCourse+", "+idStudent+")");
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
