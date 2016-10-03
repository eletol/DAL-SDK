using System.Collections.Generic;
using EmpPayroll.Services.Domain.Models;

namespace EmpPayroll.Services.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<Models.ApplicationUser> GetAll();
        ApplicationUser GetById(string id);

        //Models.ApplicationUser Save(Models.ApplicationUser user);

        //Models.ApplicationUser Update(Models.ApplicationUser user);
        //bool Delete(Models.ApplicationUser item);

    }
}