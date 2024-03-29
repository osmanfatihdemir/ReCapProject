﻿using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetById(int id);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(IFormFile file,CarImage carImage);
        IResult Add(IFormFile file, CarImage carImage);
    }
}
