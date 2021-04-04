using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,DailyPrice=170,Description="Reno 2015",ModelYear=2015},
                new Car{Id=2,BrandId=1,DailyPrice=100,Description="Reno 2012",ModelYear=2012},
                new Car{Id=3,BrandId=2,DailyPrice=200,Description="Mersedes 2016",ModelYear=2016},
                new Car{Id=4,BrandId=3,DailyPrice=300,Description="Volkswagen 2020",ModelYear=2020},
                new Car{Id=5,BrandId=3,DailyPrice=150,Description="Volkswagen 2018",ModelYear=2018},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.Find(c => c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;

        }
    }
}
