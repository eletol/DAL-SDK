using System.Collections.Generic;
using System.Linq;
using EmpPayroll.Services.Domain.Collections;
using EmpPayroll.Services.Domain.Interfaces;
using EmpPayroll.Services.Domain.Models;

namespace EmpPayroll.Services.Domain.Repos
{
    public class UserRepository : GenericRepository<ApplicationUsers, ApplicationUser>, IUserRepository
    {
        public IEnumerable<Models.ApplicationUser> GetAll()
        {
            IEnumerable<ApplicationUser> users = QueryByAll().ToList();
            return users;            

        }

        public new IEnumerable<Models.ApplicationUser> GetById(string id)
        {
           return base.GetById(id,"Id");
        }

        //public Models.ApplicationUser Save(Models.ApplicationUser users)
        //{
        //   return base.Save(user);
        //}


        //public Models.ApplicationUser Update(Models.ApplicationUser user)
        //{
        //    var c = base.GetCollection();
        //    var m= c.QueryByUniqueId(user.Id);
        //    m.First().GDefinition = user.GDefinition;
        //    m.First().GTerm = user.GTerm;
        //    c.Update();
        //    return user;
        //}
        //public bool Delete(Models.ApplicationUser user)
        //{
        //    var c = base.GetCollection();
        //    var m = c.QueryByUniqueId(item.GId);
        //    return c.Delete(m.First());
        //}
    }
}