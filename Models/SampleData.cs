using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogyxAccounting.Models {
    static class SampleData {
        public static List<SampleOrder> Orders = new List<SampleOrder>() {
            new SampleOrder {
                 BarCode="1234567890123",
                  Discount=50,
                   Id=1,
                    MeasuringUnit="ცალი",
                            Name="კალამი",
                     Price=100,
                      ProductCode="SP001",
                       ProductGroup="საკანცელარიო",
                        TypeOfTaxation="ჩვეულებრივი",
                         Quantity=10,
                          UpdateDate=DateTime.Now
            },
            new SampleOrder {
                  BarCode="12345678901456",
                  Discount=50,
                   Id=2,
                    MeasuringUnit="ცალი",
                            Name="ბორბალი",
                     Price=100,
                      ProductCode="SP001",
                       ProductGroup="მანქანა",
                        TypeOfTaxation="ჩვეულებრივი",
                         Quantity=10,
                          UpdateDate=DateTime.Now
            },
            new SampleOrder {
                    BarCode="1234567890123",
                  Discount=50,
                   Id=2,
                    MeasuringUnit="ცალი",
                    Name="წიგნი",
                     Price=100,
                      ProductCode="SP001",
                       ProductGroup="განათლება",
                        TypeOfTaxation="ჩვეულებრივი",
                         Quantity=10,
                          UpdateDate=DateTime.Now
            }
        };
    }
}
