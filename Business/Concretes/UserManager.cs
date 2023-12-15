using AutoMapper;
using Business.Abstracts;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Concretes;
using Entity.Requests;
using Entity.Responses;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;
        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(AddUserRequest addUserRequest)
        {
            try
            {
                User user = _mapper.Map<User>(addUserRequest);
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int id)
        {
            User user = _userDal.Get(user => user.Id == id);
            var result = Check(user.Id);
            if (result.Success == false)
            {
                return new ErrorResult(result.Message);
            }
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<User>>(ex.Message);
            }
        }

        public IDataResult<User> GetById(int userId)
        {
            try
            {
                var result=Check(userId);
                if (result.Success == false)
                {
                    return new ErrorDataResult<User>(result.Message);
                }
                return new SuccessDataResult<User>(_userDal.Get(user=>user.Id==userId), Messages.UserListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<User>(ex.Message);
            }
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(UpdateUserRequest updateUserRequest)
        {
            try
            {
                User user = _userDal.Get(u => u.Id == updateUserRequest.Id);
                var result = Check(user.Id);
                if (result.Success == false)
                {
                    return new ErrorResult(result.Message);
                }
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Check(int id)
        {
            try
            {
                var result = _userDal.Get(user => user.Id == id);
                if (result == null)
                {
                    return new ErrorResult(Messages.NotFound);
                }
                return new SuccessResult();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IDataResult<List<GetAllUserResponse>> GetAllUserDetails()
        {
           try {
                return new SuccessDataResult<List<GetAllUserResponse>>(_userDal.getAllUserResponses(), Messages.UsersListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<GetAllUserResponse>>(ex.Message);
            }
        }
    }
}
