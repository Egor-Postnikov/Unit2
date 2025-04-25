using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s = 0;
            int i = 0;
            long l = 0;
            float f = 0;
            double d = 0;
            object o = d;
            double d2 = (double)o;

            i = (int)l;
            l = i;
            ushort a = 15050;//0011101011001010
            byte b = (byte)a; //11001010

            TestFunc(ref i);

            var c = 0f;

            if (o!= null)
            {
                int i2 = (int)o;
            }
            int[] array = new int[1000];
            List<int> list = new List<int>(80);
        }
        void TestFunc(ref int i)
        {
            i = 10;
            Console.WriteLine(i);
        }
    }
}
