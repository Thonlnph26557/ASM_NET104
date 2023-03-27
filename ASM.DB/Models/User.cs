using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ASM.DB.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public int Status { get; set; }

        public Role Role { get; set; }
        public ICollection<Bill> Bill { get; set; }
        public Cart Cart { get; set; }
    }
}
