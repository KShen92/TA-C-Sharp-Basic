using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP124
{
    class ExerciseP124
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.firstName = "Sample";
            emp1.lastName = "Student";
            emp1.SayName();

            //ExerciseP126
            IQuittable emp2 = new Employee();
            emp2.Quit();
        }
    }
}
