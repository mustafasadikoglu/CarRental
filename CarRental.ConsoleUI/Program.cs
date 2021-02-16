using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace CarRental.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId);
            }

            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = null
            });



        }

        private static void CarDetails(CarManager carManager)
        {


            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Marka: " + car.BrandName + "\n" + "Model: " + car.CarName + "\n" + "Renk: " + car.ColorName + "\n" + "Günlük Fiyat: " + car.DailyPrice);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetByIdBrandTest(BrandManager brandManager)
        {
            //Console.WriteLine(brandManager.Get(3).Name);
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
        }

        private static void BrandList()
        {
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.Name);
            //}
        }

        private static void ColorList()
        {
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}
        }
    }
}
