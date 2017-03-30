using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Addition
    {
        //private  int sum;  //私有变量
        public void Add()
        {
            int sum = 0;//共有变量
            int n = 30;         
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);           
        }

    }
}
