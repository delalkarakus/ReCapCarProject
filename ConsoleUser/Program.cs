using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUser
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("CarId: "+ car.CarId+ " / Car Descriptions: "+ car.Descriptions+" / Car Daily Price: " + car.DailyPrice);
              
                
            }


        }
    }
}
