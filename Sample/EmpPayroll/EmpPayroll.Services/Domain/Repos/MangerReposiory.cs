using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using EmpPayroll.Services.Domain.Interfaces;
using EmpPayroll.Services.Domain.Models;
using EmpPayroll.Services.Domain.ViewModels;
using EmpPayroll.Services.Models;

namespace EmpPayroll.Services.Domain.Repos
{
    public class MangerReposiory:IMangerRepository
    {
        private ApplicationDbContext _contx = null;

        public ApplicationDbContext ContextObject
        {
            get { return _contx ?? (_contx = new ApplicationDbContext()); }
        }
        public IEnumerable<ApplicationUserViewModel> GetEmployeesPayroll(string id)
        {
           var DId= ContextObject.Mangers.Where(s => s.UserId == id).Select(b => b.DId).FirstOrDefault();
            IEnumerable<ApplicationUserViewModel> employees = null;
            if (!DId.IsEmpty())
            {
                employees = ContextObject.Users
                .Where(s => s.DId == DId && s.Id != id)
                .Select(b => new ApplicationUserViewModel()
                {
                    DId = b.DId,
                    Salary = b.Salary,
                    UserName = b.UserName
                
                }); 
            }
            return employees;

        }
    }
}