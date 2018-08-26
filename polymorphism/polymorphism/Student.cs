using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Student
    {
        public int Grade1 { get; set; }
        public int Grade2 { get; set; }
        public int Grade3 { get; set; }

        public Student(int grade1, int grade2, int grade3)
        {
            Grade1 = grade1;
            Grade2 = grade2;
            Grade3 = grade3;
        }

        public virtual int SumOfGrades()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public int HighestGrade()
        {
            if (Grade1 > Grade2 && Grade1 > Grade3)
            {
                return Grade1;
            }
            else if (Grade2 > Grade1 && Grade2 > Grade3)
            {
                return Grade2;
            }
            else return Grade3;
        }
    }
}
