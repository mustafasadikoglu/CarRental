using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalCarsContext>, IRentalDal
    {
        public List<CustomerRentDetailDto> GetRentalDetailsByEmail(Expression<Func<CustomerRentDetailDto, bool>> filter = null)
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new CustomerRentDetailDto
                             {
                                 Id = rental.Id,
                                 CarBrand = brand.Name,
                                 CarModel = car.CarName,
                                 CustomerFirstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = (DateTime)rental.ReturnDate,
                                 Email = user.Email

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<RentDetailDto> GetRentDetails()
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join customer in context.Customers
                             on rental.CustomerId equals customer.UserId
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentDetailDto
                             {
                                 Id = rental.Id,
                                 CarBrand = brand.Name,
                                 CarModel = car.CarName,
                                 CustomerFirstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = (DateTime)rental.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
