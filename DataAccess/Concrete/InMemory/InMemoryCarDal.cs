﻿using DataAccess.Abstract;
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

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 1985, DailyPrice = 20000, Description = "Beyaz Audi"},
                new Car {CarId = 2, BrandId = 1, ColorId = 2, ModelYear = 1990, DailyPrice = 30000, Description = "Siyah Audi"},
                new Car {CarId = 3, BrandId = 2, ColorId = 2, ModelYear = 2000, DailyPrice = 40000, Description = "Siyah Volvo"},
                new Car {CarId = 4, BrandId = 3, ColorId = 3, ModelYear = 2005, DailyPrice = 50000, Description = "Kırmızı Ford"},
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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCar(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
