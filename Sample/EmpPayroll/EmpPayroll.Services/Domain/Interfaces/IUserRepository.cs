using System.Collections.Generic;

namespace EmpPayroll.Services.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<Models.ApplicationUser> GetAll();
        IEnumerable<Models.ApplicationUser> GetById(string id);

        //Models.ApplicationUser Save(Models.ApplicationUser user);

        //Models.ApplicationUser Update(Models.ApplicationUser user);
        //bool Delete(Models.ApplicationUser item);

    }
}