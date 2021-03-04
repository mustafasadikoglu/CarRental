using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        //IDataResult<List<User>> GetAll();
        //IResult Add(User user);
        //IResult Delete(User user);
        //IResult Update(User user);
        //IDataResult<User> Get(int id);
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
