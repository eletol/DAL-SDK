using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpPayroll.Services.Domain.Models
{
    public class Department
    {
        [Key]
        public string DId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }


    }
}