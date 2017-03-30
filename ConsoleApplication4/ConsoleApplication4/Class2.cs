using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Class2:Class1 
    {
        // 3、基类没有默认或者无参的构造函数，则派生类必须显式调用基类的构造函数
        public Class2()
            : base(123)
        {
            Console.WriteLine("##########");
        }


        public void F1()
        {
            Console.WriteLine(d);
            Console.WriteLine(base.d);
            Console.WriteLine(base.p);
            base.F_Class1();
            F2();
        }

        public override void F2()
        {
            base.F2();   
            Console.WriteLine("!!!!!!!");
        }
    }
}
