using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    public delegate string MyDelegate(string str);
    public class Calc
    {
        public string Uppercase(string str)
        {
            return str.ToUpper();
        }

        public string Lowercase(string str)
        {
            return str.ToLower();
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            MyDelegate myDelegate = new MyDelegate(calc.Uppercase);
            myDelegate += new MyDelegate(calc.Lowercase);
            Delegate[] list = myDelegate.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke("akash"));
            }
        }
    }
}
