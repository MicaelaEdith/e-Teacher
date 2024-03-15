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

        public List<Courses> ListCourses(int id)
        {

            List<Courses> listCourses = new List<Courses>();
            DataAccess data = new DataAccess();

            try
            {
                data.Query("SELECT c.id, c.curso_materia, c.dia_horario, c.institucion FROM cursos_alumnos ca JOIN cursos c ON ca.curso = c.id WHERE ca.alumno =" + id + ";");

                data.Read();

                while (data.Reader.Read())
                {
                    Courses aux = new Courses();

                    aux.Id = (int)data.Reader["Id"];
                    aux.CoursesClasses = (string)data.Reader["curso_materia"];
                    aux.Days = (string)data.Reader["dia_horario"];
                    aux.Institution = (string)data.Reader["institucion"];

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

        public int AddStudent(string name, string lastName)
        {
            DataAccess data = new DataAccess();
            int studentId = -1;

            try
            {
                data.Query("insert into alumnos values ('" + name + "','" + lastName + "',1)");
                data.Insert();

                data.Query("SELECT SCOPE_IDENTITY()");
                studentId = data.GetScalarValue<int>();
                Console.WriteLine(studentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                data.closeConnection();
            }

            return studentId;
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

        public void DeleteCourse(int idStudent, int idCourse)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.Query("DELETE from cursos_alumnos where curso= " + idCourse + " and alumno = " + idStudent);
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

        public Dictionary<string, int> ListCoursesWithMostStudents()
        {
            Dictionary<string, int> coursesWithStudents = new Dictionary<string, int>();
            DataAccess data = new DataAccess();

            try
            {
                data.Query("SELECT c.curso_materia, COUNT(ca.alumno) AS num_students FROM cursos_alumnos ca JOIN cursos c ON ca.curso = c.id GROUP BY c.curso_materia ORDER BY num_students DESC");

                data.Read();

                while (data.Reader.Read())
                {
                    string courseName = (string)data.Reader["curso_materia"];
                    int numStudents = (int)data.Reader["num_students"];

                    coursesWithStudents.Add(courseName, numStudents);
                }

                return coursesWithStudents;
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
