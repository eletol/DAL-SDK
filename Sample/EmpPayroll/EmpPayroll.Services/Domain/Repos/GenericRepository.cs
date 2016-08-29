using System.Collections.Generic;
using System.Linq;
using DAL.SDK.common;
using EmpPayroll.Services.Models;

namespace EmpPayroll.Services.Domain.Repos
{
    public class GenericRepository<TCollection, TItem>
        where TCollection : BusinessCollection<TItem, ApplicationDbContext>, new()
        where TItem : class,new()
    {

        public IEnumerable<TItem> QueryByAll()
        {
            var c = new TCollection();
            return c.QueryByAll().ToList();
        }
        public IEnumerable<TItem> GetById(string id,string idProp)
        {
            var c = new TCollection();

            return c.QueryByUniqueId(id, idProp);
        }
        public TItem Save(TItem item)
        {
            var c = new TCollection();
            return c.Save(item);
        }

        public TCollection GetCollection()
        {
            var c = new TCollection();
            return c;

        }
    }
}