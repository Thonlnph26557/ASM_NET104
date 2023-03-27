namespace ASM.DB.Models
{
    public class Cart
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }

        public ICollection<CartDetail> CartDetail { get; set; }
        public User User { get; set; }
    }
}
