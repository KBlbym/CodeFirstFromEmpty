using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFromEmpty
{
    public class Student

    {

        public Student()

        {

        }

        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public byte[] Photo { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }



        public Grade Grade { get; set; }

    }
}
