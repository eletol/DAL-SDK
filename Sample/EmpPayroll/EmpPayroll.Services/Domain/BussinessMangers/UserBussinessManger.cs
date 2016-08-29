using System;
using System.Collections.Generic;
using System.Linq;
using EmpPayroll.Services.Domain.Interfaces;

namespace EmpPayroll.Services.Domain.BussinessMangers
{
    public class UserBussinessManger
    {
        private readonly IUserRepository _repository;


        public UserBussinessManger(IUserRepository repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("no repository provided");
            }
            this._repository = repo; 
        }
        public IEnumerable<Models.ApplicationUser> GetAll()
        {

            return _repository.GetAll();
        }
        public Models.ApplicationUser GetById(string id)
        {

            return _repository.GetById(id).First();
        }
        //public Models.GlossaryItem Save(Models.GlossaryItem item)
        //{
        //    Models.GlossaryItem sitem = _repository.Save(item);
        //    return sitem;
        //}


        //public  Models.GlossaryItem Update(Models.GlossaryItem item)
        //{
        //    Models.GlossaryItem uitem = _repository.Update(item);
        //    return uitem;
        //}

        //internal  bool Delete(Models.GlossaryItem item)
        //{
        //   return _repository.Delete(item);
        //}
    }
}