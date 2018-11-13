using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP124
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Left the table.");
            Console.ReadLine();
        }
    }
}
