using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Class1
    {
        public static void DivideByZero()
        {
            int i = 10;
            int j = 0;
            Console.WriteLine(i / j); 
        }
        public static void NullPoinerException()
        {
            Console.WriteLine("Enter Number");
            //---Do Not Enter Any Number Just Enetr
            int i = int.Parse(Console.ReadLine());
        }
        public static void IndexOutOfBound()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };

            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[10]);
            }
        }
        public static void NumberFormatException()
        {
            Console.WriteLine("Enetr Number in Words");
            // 
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine(j);
        }
        public static void Exception()
        {

        }
    }
}
