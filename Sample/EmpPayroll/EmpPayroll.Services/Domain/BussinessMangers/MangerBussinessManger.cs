using System;
using System.Collections.Generic;
using System.Linq;
using EmpPayroll.Services.Domain.Interfaces;
using EmpPayroll.Services.Domain.Models;
using EmpPayroll.Services.Domain.ViewModels;

namespace EmpPayroll.Services.Domain.BussinessMangers
{
    public class MangerBussinessManger
    {
        private readonly IMangerRepository _repository;


        public MangerBussinessManger(IMangerRepository repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("no repository provided");
            }
            this._repository = repo; 
        }
        public IEnumerable<ApplicationUserViewModel> GetEmployeesPayroll(string id)
        {

            return _repository.GetEmployeesPayroll(id);
        }
    
     
    }
}