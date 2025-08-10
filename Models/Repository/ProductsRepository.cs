namespace LogyxAccounting.Models.Repository
{
    public class ProductsRepository
    {
            public int id { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string barcode { get; set; }
            public decimal price { get; set; }
            public decimal sale_percent { get; set; }
            public int taxation_type_id { get; set; }
            public int type_id { get; set; }
            public int measure_unit_id { get; set; }
            public int category_id { get; set; }
        
    }
}
