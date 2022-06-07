using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace C_upsB.Models
{
    public class User:IdentityUser
    {
        [Required]
        public string Fullname { get; set; }

        public bool IsActive { get; set; }
    }
}