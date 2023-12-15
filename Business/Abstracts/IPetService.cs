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
    public interface IPetService
    {
        IResult Add(AddPetRequest addPetRequest);
        IResult Delete(int petId);
        IDataResult<List<Pet>> GetAll();
        IDataResult<Pet> GetById(int petId);
        IResult Update(UpdatePetRequest updatePetRequest);
        IDataResult<List<GetAllPetDetails>> GetAllPetDetails();
    }
}
