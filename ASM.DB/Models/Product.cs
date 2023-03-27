using System.ComponentModel;

namespace ASM.DB.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [DisplayName("Tên")]
        public string Name { get; set; }
        [DisplayName("Giá bán")]
        public double Price { get; set; }
        [DisplayName("Số lượng tồn")]
        public int AvaiableQuantity { get; set; }
        [DisplayName("Trạng thái")]
        public int Status { get; set; }
        [DisplayName("Đối tượng cung cấp")]
        public string Supplier { get; set; }
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<BillDetail> BillDetail { get; set; }
        public ICollection<CartDetail> CartDetail { get; set; }
    }
}
