using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentalCarsContext>, ICustomerDal
    {
        public CustomerDetailDto GetByEmail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (RentalCarsContext context = new RentalCarsContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id                            

                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 UserId = c.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName,
                                 FindexPoint = (from f in context.Findex where f.UserId == c.UserId select f.Point).FirstOrDefault()
                             };

                return result.SingleOrDefault(filter);
            }
        }

        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (var context = new RentalCarsContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id                            
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 UserId = c.UserId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName,
                                 FindexPoint = (from f in context.Findex where f.UserId == c.UserId select f.Point).FirstOrDefault()
                             };
                // (from a in context.CarImages where a.CarId == c.Id select a.ImagePath).FirstOrDefault()

                return result.ToList();
            }
        }
    }
}
