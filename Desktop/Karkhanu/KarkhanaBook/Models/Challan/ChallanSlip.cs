using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarkhanaBook.Models.Challan
{
    public class ChallanSlip
    {
        public string SellerName { get; set; }
        public string Range_CartoonSerialNumber { get; set; }
        public int TotalCartoons { get; set; }
        public float Rs_PerKG { get; set; }
        public float TotalWeight { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string Remark{get;set;}
    }
}
