using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alfa.Core
{
   public interface IDataAccess<T> where T:class
    {
        int Insert(T obj);
        int Delete(T obj);
        int Update(T obj);
        int Save();
        List<T> List();
        T Find(Expression<Func<T, bool>> where);
        List<T> List(Expression<Func<T,bool>> where);
        IQueryable<T> ListQueryable();


        
    }
}
