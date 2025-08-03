using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogyxAccounting.Models {
    public class SampleOrder {
        public int Id { get; set; }
        public DateTime UpdateDate{ get; set; }
        public string Name { get; set; }
        public string ProductGroup { get; set; }
        public string MeasuringUnit { get; set; }
        public string ProductCode { get; set; }
        public string BarCode { get; set; }
        public string TypeOfTaxation { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
