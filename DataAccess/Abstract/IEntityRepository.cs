using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip 
    //IEntity:  IEntity olabilir ya da IEntity imlemente eden bir nesne olabilir.
    //new() : nem'lenebilir olabilir.Not: interfaceler nem'lenemez.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //Datayı çekerken filtreleme yapabilir. Null olduğu için yapmayadabilir.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
