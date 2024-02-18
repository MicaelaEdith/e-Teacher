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
                data.Query("Select curso_materia, dia_horario, institucion, nivel from cursos;");
                data.Read();

                while (data.Reader.Read())
                {
                    Courses aux = new Courses();

                    aux.CoursesClasses = (string)data.Reader["curso_materia"];
                    aux.Days = (string)data.Reader["dia_horario"];
                    aux.Institution = (string)data.Reader["institucion"];
                    aux.Level = (string)data.Reader["nivel"];

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
                data.Insert();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                data.closeConnection();
            }
        }


    }
}
