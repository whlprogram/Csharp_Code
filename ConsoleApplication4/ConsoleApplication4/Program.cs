using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 c = new Class1(456);
            //Console.WriteLine(c.p);

            Class2 c = new Class2();
            c.F1();



            //补位运算
            //int[] values = { 0, 0x111, 0xfffff, 0x8888, 0x22000022 };
            //foreach (int v in values)
            //{
            //    Console.WriteLine("~0x{0:x8} = 0x{1:x8}", v, ~v);
            //}
        }
    }
}
