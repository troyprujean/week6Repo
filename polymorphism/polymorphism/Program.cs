using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ITStudent iTStudent1 = new ITStudent(50,23,54);
            ITStudent iTStudent2 = new ITStudent(22,65,98);
            ITStudent iTStudent3 = new ITStudent(45,66,12);
            ITStudent iTStudent4 = new ITStudent(65,76,87);
            ITStudent iTStudent5 = new ITStudent(34,65,98);

            Console.WriteLine($"The average grade for IT Student 1 is: {iTStudent1.SumOfGrades()}");
            Console.WriteLine($"The average grade for IT Student 2 is: {iTStudent2.SumOfGrades()}");
            Console.WriteLine($"The average grade for IT Student 3 is: {iTStudent3.SumOfGrades()}");
            Console.WriteLine($"The average grade for IT Student 4 is: {iTStudent4.SumOfGrades()}");
            Console.WriteLine($"The average grade for IT Student 5 is: {iTStudent5.SumOfGrades()}");

            BusinessStudent businessStudent1 = new BusinessStudent(43,54,76);
            BusinessStudent businessStudent2 = new BusinessStudent(25, 76, 23);
            BusinessStudent businessStudent3 = new BusinessStudent(66, 98, 12);
            BusinessStudent businessStudent4 = new BusinessStudent(45, 64, 78);
            BusinessStudent businessStudent5 = new BusinessStudent(32, 99, 100);

            Console.WriteLine($"The highest grade for Business Student 1 is: {businessStudent1.HighestGrade()}");
            Console.WriteLine($"The highest grade for Business Student 2 is: {businessStudent2.HighestGrade()}");
            Console.WriteLine($"The highest grade for Business Student 3 is: {businessStudent3.HighestGrade()}");
            Console.WriteLine($"The highest grade for Business Student 4 is: {businessStudent4.HighestGrade()}");
            Console.WriteLine($"The highest grade for Business Student 5 is: {businessStudent5.HighestGrade()}");

            List<Student> studentList = new List<Student>
            {
                iTStudent1,
                iTStudent2,
                iTStudent3,
                iTStudent4,
                iTStudent5,
                businessStudent1,
                businessStudent2,
                businessStudent3,
                businessStudent4,
                businessStudent5
            };

            foreach (Student student in studentList)
            {
                Console.WriteLine($"\n\nGrade 1: {student.Grade1}\nGrade 2: {student.Grade2}\nGrade 3: {student.Grade3}");
            }
        }
    }
}
