using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KarkhanaBook.Models.Sheet
{
    public class KarigerDailySheet
    {
        public string UserName { get; set; }
        public float AVG_Machine { get; set; }
        public int MachineNumber { get; set; }
        public string Shift { get; set; }
        public DateTime Date { get; set; }
    }
}
