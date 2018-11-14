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

            //ExerciseP129
            emp1.Id = 1;
            Employee emp3 = new Employee();
            emp3.Id = 3;
            Employee emp4 = new Employee();
            emp4.Id = 1;
            bool notEqual = false;
            bool isEqual = false;

            if ((emp1 != emp3) == true)
            {
                Console.WriteLine("IDs are not equal.");
                Console.ReadLine();
            }
            
            if ((emp1 == emp4) == true)
            {
                Console.WriteLine("These IDs ARE equal.");
                Console.ReadLine();
            }
        }
    }
}
