using ApiApplication.models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiApplication.Models
{
    public class Users : CommonEntityProperties
    {
        [Key]
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string? Phone { get; set; }
        public List<Roles> roles { get; set; } = new List<Roles>();
        public bool IsVerified { get; set; } = false;

    }
}
