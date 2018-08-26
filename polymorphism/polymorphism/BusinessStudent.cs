using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class BusinessStudent : Student
    {
        public BusinessStudent(int grade1, int grade2, int grade3) : base(grade1, grade2, grade3)
        {
        }
    }
}
