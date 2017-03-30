using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Class1
    {
        public void F1()
        {
            bool b = true;
            //b = false;  // 取消注释后下面的if均不能运行 

            if (b == true )
            {
                Console.WriteLine(b);
            }

            if (b)    //默认为b == true，只有bool类型能这样
            {
                Console.WriteLine(b);
            }
        }

        public void F2()
        {
            int row = 10;
            int column;

            while (row >= 1)
            {
                column = 1;

                while (column <= 10)
                {
                    Console.Write(row % 2 == 1 ? "<" : ">");
                    ++column;
                } // end while`

                --row;
                Console.WriteLine();
            } // end while
        }

        public void F3()
        {
            int a = Convert.ToInt32(Console .ReadLine ());
            bool t = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    t = false;
                }
            }
            Console.WriteLine(t);
        }
    }
}
