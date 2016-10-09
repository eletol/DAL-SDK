using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using App.Services.Domain.Models;
using App.Services.Domain.Repository.Interfaces;


namespace App.Services.Domain.BussinessMangers.Classes
{
    public class DepartmentBussinessManger : BaseBussinessManger<Department>
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentBussinessManger(IDepartmentRepository repo) : base(repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("no repository provided");
            }
            this._repository = repo;
        }

        public override IQueryable<Department> Get(Expression<Func<Department, bool>> filter = null, Func<IQueryable<Department>, IOrderedQueryable<Department>> orderBy = null, string includeProperties = "")
        {
            return base.Get(filter, orderBy, "Employees");
        }
    }
}