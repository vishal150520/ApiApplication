using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ApiApplication.Models
{
    public class UserRoles
    {
        [Key]
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public Roles? Roles { get; set; }
    }
}