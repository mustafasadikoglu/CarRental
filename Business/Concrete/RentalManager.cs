using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rendalDal;

        public RentalManager(IRentalDal rendalDal)
        {
            _rendalDal = rendalDal;
        }

        public IResult Add(Rental rental)
        {
            var results = _rendalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate != null)
                {
                    _rendalDal.Add(rental);
                    new SuccessResult(Messages.CarRentSuccess);
                }
            }     
            
            return new ErrorResult(Messages.CarNotAvailable);

        }

        public IResult Delete(Rental rental)
        {
            _rendalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rendalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rendalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rendalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
