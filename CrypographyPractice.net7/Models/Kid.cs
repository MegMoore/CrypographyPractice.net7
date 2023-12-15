using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrypographyPractice.net7.Models
{
    [Index("Username", IsUnique = true)]
    public class Kid
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;
        [StringLength(50)]
        public string HashPassword { get; set; } = string.Empty;
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        
        public DateTime DateOfBirth { get; set; }
        public DateTime AdmissionDate { get; set; } = DateTime.Now;

    }
}
