using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP131
{
    public class Employee<T> : Person, IQuittable
    {
        //public int Id;

        //public static bool operator ==(Employee<int> emp1, Employee<int> emp3)
        //{
        //    bool isEqual = false;
        //    if (emp1.Id == emp3.Id)
        //    {
        //        isEqual = true;
        //    }
        //    return isEqual;
        //}

        //public static bool operator !=(Employee<int> emp1, Employee<int> emp3)
        //{
        //    bool notEqual = false;
        //    if (emp1.Id != emp3.Id)
        //    {
        //        notEqual = true;
        //    }
        //    return notEqual;
        //}

        public void Quit()
        {
            Console.WriteLine("Left the table.");
            Console.ReadLine();
        }

        public List<T> things = new List<T>();

    }
}
