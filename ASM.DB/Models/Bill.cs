namespace ASM.DB.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }

        public User User { get; set; }
        public ICollection<BillDetail> BillDetail { get;set; }
    }
}
