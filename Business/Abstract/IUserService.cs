﻿using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);

        //IDataResult<List<CarDetailDto>> GetCarDetail();
        IResult Update(User user);
        IResult Delete(User user);
        IResult Add(User user);
    }
}
