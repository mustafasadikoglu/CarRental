using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add( CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);
        IResult Update (CarImage carImage, IFormFile file);        
        IDataResult<List<CarImage>> GetImagesByCarId(int id);
        IResult Update(CarImage carImage);

    }
}
