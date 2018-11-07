using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP114
{
    public class MathOps
    {
        public int MathOps1(int num1)
        {
            int mathNum1 = num1 * 2;
            return mathNum1;
        }

        public double MathOps2(double num2)
        {
            double mathTemp2 = num2 * 3;
            int mathNum2 = Convert.ToInt32(mathTemp2);
            return mathNum2;
        }

        public int MathOps3(int num3)
        {
            int mathNum3 = num3 * 4;
            return mathNum3;
        }
    }
}
