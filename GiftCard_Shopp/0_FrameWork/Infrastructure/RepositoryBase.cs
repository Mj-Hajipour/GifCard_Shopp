using _0_FrameWork.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace _0_FrameWork.Infrastructure
{
    public class RepositoryBase<Tkey, T> : IRepository<Tkey, T> where T :class 
    {
        

        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public T Get(Tkey id)
        {
            throw new NotImplementedException();
        }

        public List<T> Get()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
