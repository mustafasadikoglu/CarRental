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
            //brandManager.Add(new Brand() { Name = "Citroen" });

            BrandList();

            Console.WriteLine("----------------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color() { Name = "Yeşil" });

            ColorList();

            //GetByIdBrandTest(brandManager);

            Console.WriteLine("----------------------------");

            //JoinTest
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Marka: " + car.BrandName + "\n" + "Model: " + car.CarName + "\n" + "Renk: " + car.ColorName + "\n" + "Günlük Fiyat: " + car.DailyPrice);
            }


        }

        private static void GetByIdBrandTest(BrandManager brandManager)
        {
            Console.WriteLine(brandManager.Get(3).Name);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void BrandList()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void ColorList()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }
    }
}
