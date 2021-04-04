using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetById(int id);
        IResult Update(T entity);
        IResult Delete(T entity);
        IResult Add(T entity);
    }
}
