using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusExHarvest.ForBase
{
    class Sales
    {
        public UInt32 id { get; set; }
        public UInt32 idCheck { get; set; } 
        public UInt32 dateTime { get; set; }
        public Int32 fpNumber { get; set; }
        public int sort { get; set; }  
        public bool type { get; set; }
        public int amount { get; set; }
        public int amount_Status { get; set; }
        public bool isOneQuant { get; set; }
        public UInt32 price { get; set; }
        public int nalogGroup { get; set; }
        public bool memoryGoodName { get; set; }
        public string goodName { get; set; }
        public string StrCode { get; set; }
        public int packname { get; set; }
        public UInt32 rowSum { get; set; }
        public string comment { get; set; }

    }
}
