using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace Business
{
    public class CoursesManager
    {
        public List<Courses> ListCourses()
        {

            List<Courses> listCourses = new List<Courses>();
            DataAccess data = new DataAccess();

            try
            {
                data.Query("Select id, curso_materia, dia_horario, institucion, nivel from cursos;");
                data.Read();

                while (data.Reader.Read())
                {
                    Courses aux = new Courses();

                    aux.CoursesClasses = (string)data.Reader["curso_materia"];
                    aux.Days = (string)data.Reader["dia_horario"];
                    aux.Institution = (string)data.Reader["institucion"];
                    aux.Level = (string)data.Reader["nivel"];
                    aux.Id= (int)data.Reader["id"];

                    listCourses.Add(aux);
                }
                return listCourses;

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

        public void AddCourse(Courses c)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.Query("insert into cursos values ('" + c.CoursesClasses + "','" + c.Days + "','" + c.Institution + "','" + c.Level + "');");
                data.Read();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                data.closeConnection();
            }
        }

        public void Delete(int id)
        {

            DataAccess data = new DataAccess();
            try
            {
                data.Query("update cursos set activo = 0 where id = " + id);
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
        public string findNameByid(int id) {

            DataAccess data = new DataAccess();
            string name = "";

            try
            {
                data.Query("Select curso_materia from cursos where id="+id);
                data.Read();

                while (data.Reader.Read())
                {
                    name = (string)data.Reader["curso_materia"];
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

        public Courses findByid(int idValue)
        {
            DataAccess data = new DataAccess();
            Courses c = new Courses();
            try
            {
                data.Query("Select curso_materia,dia_horario,institucion, nivel, activo from cursos where id=" + idValue);
                data.Read();

                while (data.Reader.Read())
                {
                    c.Id = idValue;
                    c.CoursesClasses = (string)data.Reader["curso_materia"];
                    c.Days = (string)data.Reader["dia_horario"];
                    c.Institution = (string)data.Reader["Institucion"];
                    c.Level = (string)data.Reader["nivel"];
                    c.available = (bool)data.Reader["activo"];
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

            return c;
        }

   

    }
}
