using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP162
{
    public class Construct
    {
        public Construct() : this("Ultima Weapon",8)
        {
        }
        public Construct (string constructName, int varInput)
        {
            Name = constructName;
            Count = varInput;
        }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
