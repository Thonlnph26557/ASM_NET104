using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASM.DB.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [DisplayName("Tên")]
        public string Name { get; set; }
        [DisplayName("Giá bán")]
        [Range(1.0000000000001, int.MaxValue, ErrorMessage = "Giá bán phải lớn hơn 1")]
        public double Price { get; set; }
        [DisplayName("Số lượng tồn")]
        [Range(2, int.MaxValue, ErrorMessage ="Số lượng phải lớn hơn 1")]
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
