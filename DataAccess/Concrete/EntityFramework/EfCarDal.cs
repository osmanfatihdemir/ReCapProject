using Core.DateAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorId equals color.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             select new CarDetailDto { Description = car.Description, BrandName = brand.BrandName, 
                                 ColorName = color.ColorName, DailyPrice = car.DailyPrice };
                return result.ToList();
            }
        }
    }
}
