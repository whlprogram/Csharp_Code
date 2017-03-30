using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Class1
    {
        public void F1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string s = "";
            int b = a;
            for (int i = 10; i < a; i = i * 10)
            {
                int j = b % 10;
                s = s + j + "\t";
                b = a / i;
            }
            Console.WriteLine(s+b);
        }

        public void F2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string s = "";
            for (int i = 1; i < a; i = i * 10)
            {
                int j =  a / i% 10;
                s = "\t" + j + s;
                
            }
            Console.WriteLine(s);
        }

        private int x;
        private int y;


        protected int l;

        public void F3()
        {
            if (y == 8)
            {
                if (x == 5)
                    Console.WriteLine("@@@@@");
                else
                {
                    Console.WriteLine("#####");
                    Console.WriteLine("￥￥￥￥￥");
                    Console.WriteLine("&&&&&");
                }
            }

            Console.WriteLine(l);

        }

        
    }
}
