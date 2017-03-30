using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Class1
    {
        // 1、基类有默认的构造函数，派生类可以显式或者隐式调用基类的构造函数
        // 2、基类有无参的构造函数，派生类可以显式或者隐式调用基类的构造函数
        // 3、基类没有默认或者无参的构造函数，则派生类必须显式调用基类的构造函数

        public Class1()
        {
            Console.WriteLine("!!!!!!!!!!!");
        }


        public Class1(int i)
        {
            Console.WriteLine(i + "!!!!!!!!!!!");
        }

        protected int p;
        public double d;

        public void F_Class1()
        {
        }

        public virtual void F2()
        {
            //F2();
            Console.WriteLine("Base");
        }
    }
}
