﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FindexManager : IFindexService
    {
        IFindexDal _findexDal;

        public FindexManager(IFindexDal findexDal)
        {
            _findexDal = findexDal;
        }

        public IResult Add(Findex findex)
        {
            _findexDal.Add(findex);
            return new SuccessResult();
        }

        public IDataResult<Findex> GetFindexByUserId(int userId)
        {
            return new SuccessDataResult<Findex>(_findexDal.Get(f => f.UserId == userId));
        }
    }
}
