using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student
    {
        public int Id { get; set; }

        [DisplayName("Apellico")]
        public String LastName { get; set; }

        [DisplayName("Nombre")]
        public String Name { get; set; }

        [DisplayName("Activo")]
        public bool available { get; set; }
    }
}
