using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace App.Services.Domain.DBContext
{
  
        public interface IDbContext
        {
            IDbSet<T> Set<T>() where T : class;
            int SaveChanges();
            DbEntityEntry Entry(object o);
            void Dispose();
        }
}