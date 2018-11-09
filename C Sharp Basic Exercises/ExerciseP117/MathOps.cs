using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP117
{
    public class MathOps
    {
        public void MathOps1(out int result1, double num1)
        {
            double temp1 = num1 / 2;
            result1 = Convert.ToInt32(temp1);
        }

        public void MathOps1(out double result2, double num1, int num2)
        {
            result2 = num1 * num2;
        }
    }
}
