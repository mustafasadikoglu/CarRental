using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalCarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName
                             };
                return result.ToList();


            }
        }
    }
}
