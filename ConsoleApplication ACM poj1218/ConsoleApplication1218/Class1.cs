using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1218
{
    class Class1
    {
        public void F1()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            bool[] array = new bool[n];
            for (int x = 2; x <= n; x++)
                for (int j = x; j <= n; j += x)
                    array[j - 1] = !array[j - 1];
            foreach (bool cell in array)
                if (cell == false)
                    num += 1;
            if (n < 5 || n > 100)
                Console.WriteLine("");
            else
                Console.WriteLine(num);
        }
    }
}
