using Core.Utilities.Results.Abstracts;
using Entity.Concretes;
using Entity.Requests;
using Entity.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IResult Add(AddUserRequest addUserRequest);
        IResult Delete(int userId);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        IResult Update(UpdateUserRequest updateUserRequest);
        IDataResult<List<GetAllUserResponse>> GetAllUserDetails();
    }
}
