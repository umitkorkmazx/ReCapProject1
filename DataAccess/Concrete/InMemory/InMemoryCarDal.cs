using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars  = new List<Car>
            {
                new Car{CarId = 1, BrandId =1, ColorId=1, DailyPrice=1590, ModelYear=2015, Description="Sahibinden temiz"},
                new Car{CarId = 5, BrandId =2, ColorId=3, DailyPrice=3250, ModelYear=2068, Description="Senden iyi"},
                new Car{CarId = 3, BrandId =4, ColorId=2, DailyPrice=6310, ModelYear=2025, Description="Ondan güzel"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Car GetCarsById(int id)
        {
            throw new NotImplementedException();
        }

        //public Car GetById(Car car)
        //{
        //    return car.(c => c.CarId == id).ToList();
        //}
    }
}
