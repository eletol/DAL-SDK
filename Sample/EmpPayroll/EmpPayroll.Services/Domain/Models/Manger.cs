using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpPayroll.Services.Domain.Models
{
    public class Manger
    {
        [Required]
        [Key, Column(Order = 0)]
        public string DId { get; set; }

        [Required]
        [Key, Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual Department Department { get; set; }



    }
}