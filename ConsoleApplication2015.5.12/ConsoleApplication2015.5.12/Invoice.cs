using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2015._5._12
{
    class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal PartPrice;
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PartPrice = price;
        }
        public decimal Price
        {
            get
            {
                return PartPrice;
            }
            set
            {
                if (value >= 0M)
                {
                    PartPrice = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3,10:C}",
               PartNumber, PartDescription, Quantity, PartPrice);
        }
    }
}
