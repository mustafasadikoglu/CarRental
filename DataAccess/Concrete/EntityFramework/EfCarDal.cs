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
        public List<CarDetailDto> GetAllCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join i in context.CarImages
                             on c.Id equals i.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = b.Id,
                                 ColorId = cl.Id,                                 
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }


        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join i in context.CarImages
                             on c.Id equals i.CarId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = b.Id,
                                 ColorId = cl.Id,
                                 ImagePath = i.ImagePath,
                                 BrandName = b.Name,
                                 ColorName = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                                 ModelYear = c.ModelYear
                             };
                return result.ToList();


            }
        }


    }
}
