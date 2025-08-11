namespace LogyxAccounting.Models.Repository
{
    public class ProductCategoriesRepository
    {
        public int id { get; set; }

        public int code { get; set; }

        public int parent_code { get; set; }

        public string type { get; set; }
    }
}
