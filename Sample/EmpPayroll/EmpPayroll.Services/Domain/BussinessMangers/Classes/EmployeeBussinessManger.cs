using System;
using App.Services.Domain.Models;
using App.Services.Domain.Repository.Interfaces;


namespace App.Services.Domain.BussinessMangers.Classes
{
    public class EmployeeBussinessManger : BaseBussinessManger<Employee>
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeBussinessManger(IEmployeeRepository repo) : base(repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("no repository provided");
            }
            this._repository = repo;
        }
      
     
    }
}