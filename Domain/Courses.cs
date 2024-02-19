using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Courses
    {
        public int Id { get; set; }

        [DisplayName("Curso/Materia")]
        public String CoursesClasses { get; set; }

        [DisplayName("Día & Horario")]
        public String Days { get; set; }

        [DisplayName("Institución")]
        public String Institution { get; set; }

        [DisplayName("Nivel")]
        public String Level { get; set; }

        [DisplayName("Activo")]
        public bool available { get; set; }
    }
}
