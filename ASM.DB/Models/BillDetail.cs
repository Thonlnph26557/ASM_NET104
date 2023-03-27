namespace ASM.DB.Models
{
    public class BillDetail
    {
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
        public Bill Bill { get; set; }
    }
}
