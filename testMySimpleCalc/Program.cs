using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleCalculator;

namespace testMySimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCalc = new calculator();
            int result = testCalc.addTwoInts(5,6);

            if(result != 11)
            {
                throw new InvalidOperationException();
            }

        }
    }
}
