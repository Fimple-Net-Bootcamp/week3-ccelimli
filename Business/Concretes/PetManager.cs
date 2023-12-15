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
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class PetManager : IPetService
    {
        IPetDal _petDal;
        IMapper _mapper;

        public PetManager(IPetDal petDal, IMapper mapper)
        {
            _petDal = petDal;
            _mapper = mapper;
        }

        [ValidationAspect(typeof(PetValidator))]
        public IResult Add(AddPetRequest addPetRequest)
        {
            try
            {
                Pet pet= _mapper.Map<Pet>(addPetRequest);
                _petDal.Add(pet);
                return new SuccessResult(Messages.PetAdded);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IResult Delete(int petId)
        {
            try
            {
                var result = this.Check(petId);
                if (result.Success == false)
                {
                    return new ErrorResult(result.Message);
                }
                Pet pet = _petDal.Get(pet => pet.Id == petId);
                _petDal.Delete(pet);
                return new SuccessResult(Messages.PetDeleted);
            }
            catch (Exception ex)
            {

                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<Pet>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Pet>>(_petDal.GetAll(), Messages.PetsListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<Pet>>(ex.Message);
            }
        }

        public IDataResult<Pet> GetById(int petId)
        {
            try
            {
                var result = this.Check(petId);
                if (result.Success == false)
                {
                    return new ErrorDataResult<Pet>(result.Message);
                }
                return new SuccessDataResult<Pet>(_petDal.Get(pet => pet.Id == petId), Messages.ActivityAdded);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<Pet>(ex.Message);
            }
        }

        public IResult Update(UpdatePetRequest updatePetRequest)
        {
            try
            {
                var result = this.Check(updatePetRequest.Id);
                if (result.Success == false)
                {
                    return new ErrorResult(result.Message);
                }
                Pet pet = _mapper.Map <Pet>(updatePetRequest);      
                _petDal.Update(pet);
                return new SuccessResult(Messages.PetUpdated);
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
                var result = _petDal.Get(pet => pet.Id == id);
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

        public IDataResult<List<GetAllPetDetails>> GetAllPetDetails()
        {
            try
            {
                return new SuccessDataResult<List<GetAllPetDetails>>(_petDal.GetAllPetDetails(), Messages.PetsListed);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<GetAllPetDetails>>(ex.Message);
            }
        }
    }
}
