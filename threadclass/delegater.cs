using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threadclass
{
    // declaration of delegate
    public delegate int MyDelegate(int a, int b);
    public class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            Calc calc = new Calc();
            MyDelegate myDelegate = new MyDelegate(calc.Add);
            MyDelegate myDelegate2 = new MyDelegate(calc.Sub);
            // added the method ref
            int sum = myDelegate.Invoke(45, 23);
            int sub = myDelegate2.Invoke(45, 23);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
        }


    }

}
