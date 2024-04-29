﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T :class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);

        List<T> GetListAll();
        T GetById(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);



    }
}
