using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint : generik kısıt sadece entitiy içindeki   
    //Class: referans tip olabilir.
    //IEntity : Ientity olabilir veya Ientity İmplemente eden bir nesne olabilir. 
    //new(): newlenebilir olmalı ıentity newlenemez olduğu için ıcatogory dal a eklenemez. sadece category,customer,product gibi tablolar eklenir.
    //Expression kategoriye yada ürünün fiyatına göre getir dersen ona ayrıca metot yazmana gerek kalmaz
    public interface IEntityRepository<T> where T :class, IEntity,new() //T ya IEntitiy olmalı yada Ientity içinde implamente olmalı örn: kategoriye yada ürünün fiyatına göre getir dersen ona ayrıca metot yazmana gerek kalmaz
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  //entity deki bütün ürünleri çekmek için kullanılır yani veri tabanındaki bütün ürünleri çekmeye yarar 
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
