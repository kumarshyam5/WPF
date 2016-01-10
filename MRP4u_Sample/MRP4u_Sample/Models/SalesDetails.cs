using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRP4ME_Sample.Models
{
    public class SalesReportData
    {
        public List<SalesDetails> SalesData { get; set; }
    }

    public class SalesDetails
    {
        public int Year { get; set; }
        public decimal SalesAmount { get; set; }
    }
}
