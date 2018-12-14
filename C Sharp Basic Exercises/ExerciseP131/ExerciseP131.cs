using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP131
{
    class ExerciseP131
    {
        static void Main(string[] args)
        {
            //Employee<int> emp1 = new Employee<int>();
            //emp1.firstName = "Sample";
            //emp1.lastName = "Student";
            //emp1.SayName();

            ////ExerciseP126
            //IQuittable emp2 = new Employee<string>();
            //emp2.Quit();

            ////ExerciseP129
            //emp1.Id = 1;
            //Employee<int> emp3 = new Employee<int>();
            //emp3.Id = 3;
            //Employee<int> emp4 = new Employee<int>();
            //emp4.Id = 1;
            //bool notEqual = false;
            //bool isEqual = false;

            //if ((emp1 != emp3) == true)
            //{
            //    Console.WriteLine("IDs are not equal.");
            //    Console.ReadLine();
            //}

            //if ((emp1 == emp4) == true)
            //{
            //    Console.WriteLine("These IDs ARE equal.");
            //    Console.ReadLine();
            //}

            Employee<string> stringEmp = new Employee<string>();
            stringEmp.things.Add("string1");
            stringEmp.things.Add("string2");
            stringEmp.things.Add("string3");

            Employee<int> intEmp = new Employee<int>();
            intEmp.things.Add(1);
            intEmp.things.Add(2);
            intEmp.things.Add(3);            

            for (int thingsCount = 0; thingsCount < stringEmp.things.Count; thingsCount++)
            {
                Console.WriteLine(stringEmp.things[thingsCount]);
            }
            for (int thingsCount = 0; thingsCount < intEmp.things.Count; thingsCount++)
            {
                Console.WriteLine(intEmp.things[thingsCount]);
            }
            Console.ReadLine();
         
        }
    }
}
