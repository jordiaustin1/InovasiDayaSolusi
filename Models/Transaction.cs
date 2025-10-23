namespace ViewDataApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Amount { get; set; }
        public string CustomerName { get; set; }
        public int Status { get; set; }
        public string TransactionDate { get; set; }
        public string CreateBy { get; set; }
        public string CreateOn { get; set; }
    }
}
