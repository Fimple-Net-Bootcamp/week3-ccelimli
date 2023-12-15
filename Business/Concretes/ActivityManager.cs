using AutoMapper;
using Business.Abstracts;
using Business.Constant;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Concretes;
using Entity.Requests;
using Entity.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ActivityManager : IActivityService
    {
        IActivityDal _activityDal;
        IMapper _mapper;
        public ActivityManager(IActivityDal activityDal, IMapper mapper)
        {
            _activityDal = activityDal;
            _mapper = mapper;
        }

        //Add
        public IResult Add(AddActiviteRequest addActiviteRequest)
        {
            try
            { 
                Activity activity = _mapper.Map<Activity>(addActiviteRequest);
                _activityDal.Add(activity);
                return new SuccessResult(Messages.ActivityAdded);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int activityId)
        {
            try
            {
                Activity activity = _activityDal.Get(activity=>activity.Id == activityId);
                _activityDal.Delete(activity);
                return new SuccessResult(Messages.ActivityDeleted);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<Activity>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Activity>>(_activityDal.GetAll(),Messages.ActivitiesListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<Activity>>(ex.Message);
            }
        }

        public IDataResult<Activity> GetById(int activityId)
        {
            try
            {
                var Result = Check(activityId);
                if (Result.Success == false)
                {
                    return new ErrorDataResult<Activity>(Result.Message);
                }
                return new SuccessDataResult<Activity>(_activityDal.Get(activity => activity.Id == activityId), Messages.ActivityListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<Activity>(ex.Message);
            }
        }

        public IResult Update(UpdateActiviyRequest updateActiviyRequest)
        {
            try
            {
                var Result = Check(updateActiviyRequest.Id);
                if (Result.Success==false)
                {
                    return new ErrorResult(Result.Message);
                }

                Activity activity = _mapper.Map<Activity>(updateActiviyRequest);
                _activityDal.Update(activity);
                return new SuccessResult(Messages.ActivityUpdated);
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
                var result = _activityDal.Get(activity => activity.Id == id);
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

        IDataResult<List<GetAllActivityResponse>> IActivityService.GetAll()
        {
            try
            {
                return new SuccessDataResult<List<GetAllActivityResponse>>(_activityDal.GetAllDetails(), Messages.ActivitiesListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<GetAllActivityResponse>>(ex.Message);
            }
        }

        IDataResult<GetAllActivityResponse> IActivityService.GetById(int activityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<GetAllActivityResponse>> GetAllDetail()
        {
            try
            {
                return new SuccessDataResult<List<GetAllActivityResponse>>(_activityDal.GetAllDetails(), Messages.ActivitiesListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<GetAllActivityResponse>>(ex.Message);
            }
        }
    }
}
