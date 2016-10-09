using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.DynamicData;
using App.Services.Domain.BussinessMangers.Interfaces;
using App.Services.Domain.Repository;

namespace App.Services.Domain.BussinessMangers.Classes
{
    public class BaseBussinessManger<TEntity> : IBaseBussinessManger<TEntity> where TEntity : class
    {
        private  IBaseRepository<TEntity> _repository;
        public BaseBussinessManger(IBaseRepository<TEntity> repo)
        {
            if (repo == null)
            {
                throw new ArgumentNullException("no repository provided");
            }
            this._repository = repo;
        }

      

        public virtual TEntity GetById(object id)
        {
            return _repository.GetById(id);
        }

        public virtual TEntity Save(TEntity item)
        {
            return _repository.Save(item);
        }

        public virtual TEntity Update(TEntity entityToUpdate)
        {
            return _repository.Update(entityToUpdate);
        }

        public virtual TEntity Delete(object id)
        {
            return _repository.Delete(id);
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            return _repository.Get(filter, orderBy, includeProperties);
        }
    }

}