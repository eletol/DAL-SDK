using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpPayroll.Services.Domain.Models;
using EmpPayroll.Services.Domain.ViewModels;

namespace EmpPayroll.Services.Domain.Interfaces
{
    public interface IMangerRepository
    {
        IEnumerable<ApplicationUserViewModel> GetEmployeesPayroll(string id);

    }
}
