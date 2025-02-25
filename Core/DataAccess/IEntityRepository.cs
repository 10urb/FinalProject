﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess // core katmanları diğer katmanları referans almazlar
{ 
    //generic constraint(kısıt)
    //class: referans tip olabilir demek
    // IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir
    // new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //delege
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
