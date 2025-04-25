using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 10;
            if (b > a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else if (b < a)
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно числу {a}");
            }


            for (int i = 1; i < 10;i++)
            {
                Console.WriteLine(i);


            }

           
            
           
         
        }
        
    }
}
