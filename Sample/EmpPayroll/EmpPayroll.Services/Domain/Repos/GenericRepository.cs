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
            return c.Get().ToList();
        }
        public TItem GetById(string id)
        {
            var c = new TCollection();

            return c.GetByID(id);
        }
        public TItem Save(TItem item)
        {
            var c = new TCollection();
            return c.Insert(item);
        }

        public TCollection GetCollection()
        {
            var c = new TCollection();
            return c;

        }
    }
}