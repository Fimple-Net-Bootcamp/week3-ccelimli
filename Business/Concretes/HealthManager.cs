using AutoMapper;
using Business.Abstracts;
using Business.Constant;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class HealthManager : IHealthService
    {
        IHealthStatusDal _healthStatusDal;
        IMapper _mapper;

        public HealthManager(IHealthStatusDal healthStatusDal, IMapper mapper)
        {
            _healthStatusDal = healthStatusDal;
            _mapper = mapper;
        }

        public IResult Add(AddHealthStatusRequest addHealthStatusRequest)
        {
            try
            {
                HealthStatus healthStatus=_mapper.Map<HealthStatus>(addHealthStatusRequest);
                _healthStatusDal.Add(healthStatus);
                return new SuccessResult(Messages.HealthStatusAdded);
            }catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int healthStatusId)
        {
            try
            {
                var result = this.Check(healthStatusId);
                if (result.Success == false)
                {
                    return new ErrorResult(result.Message);
                }
                HealthStatus healthStatus = _healthStatusDal.Get(healthStatus => healthStatus.Id == healthStatusId);
                _healthStatusDal.Delete(healthStatus);
                return new SuccessResult(Messages.HealthStatusDeleted);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }

            
        }

        public IDataResult<List<HealthStatus>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<HealthStatus>>(_healthStatusDal.GetAll(),Messages.HealthStatusesListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<HealthStatus>>(ex.Message);
            }
        }

        public IDataResult<HealthStatus> GetById(int healthStatusId)
        {
            try
            {
                var result = this.Check(healthStatusId);
                if (result.Success == false)
                {
                    return new ErrorDataResult<HealthStatus>(result.Message);
                }
                return new SuccessDataResult<HealthStatus>(_healthStatusDal.Get(healtStatus=>healtStatus.Id==healthStatusId), Messages.HealthStatusListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<HealthStatus>(ex.Message);
            }
        }

        public IResult Update(UpdateHealthStatusRequest updateHealthStatusRequest)
        {
            try
            {
                var result = this.Check(updateHealthStatusRequest.Id);
                if (result.Success == false)
                {
                    return new ErrorResult(result.Message);
                }
                HealthStatus healthStatus = _mapper.Map<HealthStatus>(updateHealthStatusRequest);
                _healthStatusDal.Update(healthStatus);
                return new SuccessResult(Messages.HealthStatusUpdated);
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
                var result=_healthStatusDal.Get(healthStatus=> healthStatus.Id==id);
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
    }
}
