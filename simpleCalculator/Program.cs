using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class calculator
    {
        public int addTwoInts(int intA, int intB)
        {
            int result = intA + intB;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculator myCalc = new calculator();
            Console.WriteLine(Convert.ToString(myCalc.addTwoInts(3, 4)));
            //Console.ReadKey();
        }
    }
}
