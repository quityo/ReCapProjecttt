using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private Car car;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { 
                new Car 
                { CarId=1, 
                    ColorId=1,
                    BrandId=1,
                    ModelYear="2000", 
                    DailyPrice = 100, 
                    Description="xxx"
                },
                new Car
                { CarId=2,
                    ColorId=2,
                    BrandId=2,
                    ModelYear="2002",
                    DailyPrice = 200,
                    Description="sss"
                },
                new Car
                { CarId=3,
                    ColorId=3,
                    BrandId=3,
                    ModelYear="2003",
                    DailyPrice = 300,
                    Description="ttt"
                },
                new Car
                { CarId=4,
                    ColorId=4,
                    BrandId=4,
                    ModelYear="2004",
                    DailyPrice = 400,
                    Description="yyy"
                },
                new Car
                { CarId=5,
                    ColorId=5,
                    BrandId=5,
                    ModelYear="2005",
                    DailyPrice = 500,
                    Description="ooo"
                }

            };
        }

        public int CarId { get; private set; }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=> p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.CarId == carId ).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorID = car.ColorID;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;

        }
    }
}
