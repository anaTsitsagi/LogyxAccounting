namespace LogyxAccounting.Models.Repository
{
    public class AccountsRepository
    {
        public int id { get; set; }

        public int code { get; set; }
        
        public int parent_code { get; set; }

        public string name { get; set; }
    }
}
