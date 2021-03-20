using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetAllCarDetails(Expression<Func<CarDetailDto, bool>> filter = null);
        List<Car> GetList(Expression<Func<Car, bool>> filter = null);
    }
}
//GetById, GetAll, Add, Update, Delete