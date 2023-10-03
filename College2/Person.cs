using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College2
{
    public class Person
    {
        private static int _instanceCounter = 0;

        public Person()
        {
            Person._instanceCounter++;
        }

        public static int InstanceCount()
        {
            return Person._instanceCounter;
        }
    }
}
