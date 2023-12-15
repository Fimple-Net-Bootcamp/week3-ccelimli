using AutoMapper;
using Business.Abstracts;
using Business.Constant;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.Requests;
using Entity.Responses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    internal class FoodManager : IFoodService
    {
        IFoodDal _foodDal;
        IMapper _mapper;

        public FoodManager(IFoodDal foodDal, IMapper mapper)
        {
            _foodDal = foodDal;
            _mapper = mapper;
        }

        public IResult Add(AddFoodRequest addFoodRequest)
        {
            try
            {   
                Food food = _mapper.Map<Food>(addFoodRequest);
                _foodDal.Add(food);
                return new SuccessResult(Messages.FoodAdded);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int foodId)
        {
            try
            {
                Food food = _foodDal.Get(food => food.Id == foodId);
                _foodDal.Delete(food);
                return new SuccessResult(Messages.FoodDeleted);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
        public IDataResult<List<Food>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Food>>(_foodDal.GetAll(), Messages.FoodsListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<Food>>(ex.Message);
            }
        }

        public IDataResult<Food> GetById(int foodId)
        {
            try
            {
                return new SuccessDataResult<Food>(_foodDal.Get(food => food.Id == foodId), Messages.FoodListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<Food>(ex.Message);
            }
        }

        public IDataResult<List<GetFoodDetails>> GetFoodDetails()
        {
            try
            {
                return new SuccessDataResult<List<GetFoodDetails>>(_foodDal.GetDetail(), Messages.FoodsListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<GetFoodDetails>>(ex.Message);
            }
        }

        public IResult Update(UpdateFoodRequest updateFoodRequest)
        {
            try
            {
                Food food= _mapper.Map<Food>(updateFoodRequest);
                _foodDal.Update(food);
                return new SuccessResult(Messages.FoodUpdated);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }
    }
}
