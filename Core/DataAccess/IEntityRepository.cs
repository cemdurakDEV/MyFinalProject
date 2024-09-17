using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//CORE KATMANI DİĞER KATMANLARI REFERANS ALMAZ
namespace Core.DataAccess
{
    //Generic Repository

    //Generic Constraint
      //class:referans tip olabilir anlamında
      //IEntity: IEnttity olabilir yada IEntity implemente eden bir nesne olabilir
      //new() : new'lenebilir olmalı. Interface new'lenemez. IEntıty kullanılamaz sadece implemente eden nesneler kullanabilir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // null anlamı filtre vermeyedebiliriz anlamında
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    } 
}