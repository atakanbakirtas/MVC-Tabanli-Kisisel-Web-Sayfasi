﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrate.Repositorys
{
    public interface IRepository<T>
    {
        List<T> List();
        void Add(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List(Expression<Func<T,bool>>filter);
    }
}
