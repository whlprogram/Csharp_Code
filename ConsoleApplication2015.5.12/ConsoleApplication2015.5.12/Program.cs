using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2015._5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoices = {
         new Invoice( 83, "Electric sander", 7, 57.98M ),
         new Invoice( 24, "Power saw", 18, 99.99M ),
         new Invoice( 7, "Sledge hammer", 11, 21.50M ),
         new Invoice( 77, "Hammer", 76, 11.99M ),
         new Invoice( 39, "Lawn mower", 3, 79.50M ),
         new Invoice( 68, "Screwdriver", 106, 6.99M ),
         new Invoice( 56, "Jig saw", 21, 11.00M ),
         new Invoice( 3, "Wrench", 34, 7.50M ) };

            //遍历Invoice数组
            Console.WriteLine("Invoice array:");
            foreach (var element in invoices)
                Console.WriteLine(element);

            //(a)按PartDescription排序
            var PartDescriptionOrderby =
               from e in invoices
               orderby e.PartDescription
               select e;
            Console.WriteLine("\n按PartDescription排序:");
            foreach (var element in PartDescriptionOrderby)
                Console.WriteLine(element);

            //(b)按Price排序
            var PriceOrderby =
               from e in invoices
               orderby e.PartPrice
               select e;
            Console.WriteLine("\n按Price排序:");
            foreach (var element in PriceOrderby)
                Console.WriteLine(element);

            //(c)按PartDescription和Quantity排序
            var PDpQtyOrderby =
                from e in invoices
                orderby e.Quantity
                select e.Quantity;

            Console.WriteLine("\n选择PartDescription和Quantity，并按Quantity排序结果:");
            //只能把Quantity选出来排序了，这点有问题
            foreach (var element in PDpQtyOrderby)
                Console.WriteLine(element);           


            //(d)(e)查询在200-500美元之间的InvoiceTotal（总金额）
            var between200_500 =
               from e in invoices
               where e.Quantity * e.PartPrice >= 200M && e.Quantity * e.PartPrice <= 500M
               select e;
            Console.WriteLine(string.Format(
               "\nInvoiceTotal earning in the range {0:C}-{1:C}:",
               200, 500));
            foreach (var element in between200_500)
                Console.WriteLine(element);


        }
    }
}
