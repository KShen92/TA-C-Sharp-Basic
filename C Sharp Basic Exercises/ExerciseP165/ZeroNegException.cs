using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP165
{
    public class ZeroNegException : Exception
    {
        public ZeroNegException()
    :       base() { }
        public ZeroNegException(string message)
    :       base(message) { }        
    }
}
