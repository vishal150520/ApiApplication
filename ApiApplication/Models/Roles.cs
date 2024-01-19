using ApiApplication.models;
using System.ComponentModel.DataAnnotations;

namespace ApiApplication.Models
{
    public class Roles : CommonEntityProperties
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
