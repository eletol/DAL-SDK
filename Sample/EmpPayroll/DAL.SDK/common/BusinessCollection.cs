using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DAL.SDK.common
{
    public class BusinessCollection<TModel, TContext>
        where TModel : class,new()
        where TContext : DbContext,new()

    {
        private IObjectSet<TModel> _objectSet = null;
        private TContext _contx = null;

        public TContext ContextObject
        {
            get { return _contx ?? (_contx = new TContext()); }
        }
        internal virtual IQueryable<TModel> Scope(IQueryable<TModel> p_toScope)
        {
            return p_toScope;
        }
        private IObjectSet<TModel> EntitySet
        {
            get
            {
                if (_objectSet == null)
                {
                    _objectSet = (ContextObject as IObjectContextAdapter).ObjectContext.CreateObjectSet<TModel>();
                }
                return _objectSet;
            }
        }
        public virtual IQueryable<TModel> QueryBuilder
        {
            get
            {
                return Scope(EntitySet);
            }
        }

        public virtual IQueryable<TModel> QueryByAll()
        {
            return (from item in QueryBuilder select item);
        }


        public virtual TModel Save(TModel p_toSave)
        {
            EntitySet.AddObject(p_toSave);
            Save(true);
            return p_toSave;
            
        }
        public virtual bool Update()
        {
           
            Save(true);
            return  true;

        }
        public virtual bool Delete(TModel p_toDelete)
        {
            EntitySet.DeleteObject(p_toDelete);
            Save(true);
            return true;

        }

        public virtual IQueryable<TModel> QueryByUniqueId<T>(T id,string idProp)
        {
            string s;
            if (id is string)
            {

                s = string.Format(idProp+"=\"{0}\"", id);
 
            }
            else
            {
                 s = string.Format(idProp+"={0}", id);

            }

            var o = from item in QueryBuilder.Where(s).Cast<TModel>() select item;
            return o;     


        }
        public void Save(bool p)
        {
            if (p)
            {
                ContextObject.SaveChanges();
            }
        }
    



    }
}
