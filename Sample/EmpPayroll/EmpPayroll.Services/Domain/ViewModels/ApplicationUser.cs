using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EmpPayroll.Services.Domain.ViewModels
{
    public class ApplicationUserViewModel 
    {
        public string DId { get; set; }

        public double Salary { get; set; }
        public string UserName { get; set; }


      
    }
}