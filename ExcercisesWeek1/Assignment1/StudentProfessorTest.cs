using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercisesWeek1.Assignment1
{
    public static class StudentProfessorTest
    {
        public static void Main()
        {
            var person = new Person();
            person.Greet();

            var student = new Student();
            student.SetAge(15);
            student.Greet();
            student.ShowAge();

            var teacher = new Teacher();
            teacher.SetAge(50);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
