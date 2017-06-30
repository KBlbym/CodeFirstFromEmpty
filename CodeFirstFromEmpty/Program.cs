using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFromEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())

            {

                //Student student = new Student()
                //{
                //    Name = "New Student"
                //};
                //    ctx.Students.Add(student);
                //    ctx.SaveChanges();

                //Crear Curso
                List<Grade> courses = new List<Grade>()
                {
                    new Grade(){ Name = "Seguridad Iformatica" },
                    new Grade(){ Name = "Wep Aplicacion" },
                    new Grade(){ Name = "HTMl5, CSS, JS, otros" },
                    new Grade(){ Name = "ASP.NET" }

                };
                ctx.Grades.AddRange(courses);
                ctx.SaveChanges();

                List<Student> students = new List<Student>()
                {
                    new Student(){ Name = "Jaimito", Grade = courses[0] },
                    new Student(){ Name = "Pepito" , Grade = courses[0]},
                    new Student(){ Name = "Juanito", Grade = courses[1] },
                    new Student(){ Name = "Chin-Chan" , Grade = courses[1] },
                    new Student(){ Name = "Chin-Chan" , Grade = courses[1] }
                };
                ctx.Students.AddRange(students);
                ctx.SaveChanges();

                var getWhereMore2 = ctx.Grades.Where(p=> p.Name;
                


            }
        }
    }
}
