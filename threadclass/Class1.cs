//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace threadclass
//{
//    public delegate int MyDelegate(int a, int b);
//    public class Calc
//    {
//        public int Add(int a, int b)
//        {
//            return a + b;
//        }
//        public int Sub(int a, int b)
//        {
//            return a - b;
//        }
//        public int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//    }
//    public class Program
//    {

//        static void Main(string[] args)
//        {
//            Calc calc = new Calc();
//            MyDelegate myDelegate = new MyDelegate(calc.Add);// added the method ref
//            myDelegate += new MyDelegate(calc.Multiply);
//            myDelegate += new MyDelegate(calc.Sub); // adding ref to the list


//            myDelegate -= new MyDelegate(calc.Add); // remove the method from the list
//                                                    // working with invocation list of delegate
//            Delegate[] list = myDelegate.GetInvocationList();

//            foreach (Delegate d in list)
//            {
//                Console.WriteLine(d.Method);
//                Console.WriteLine(d.DynamicInvoke(45, 34));
//            }


//        }


//    }


//}
