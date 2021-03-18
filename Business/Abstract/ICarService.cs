using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetAllCarDetails();
        //IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);        
        IDataResult<List<CarDetailDto>> GetCarsByBrand(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColor(int id);

        IResult TransactionalOperation(Car car);
    }
}


//GetCarsByBrandId , GetCarsByColorId