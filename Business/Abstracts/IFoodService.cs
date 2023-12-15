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
    public interface IFoodService
    {
        IResult Add(AddFoodRequest addFoodRequest);
        IResult Delete(int foodId);
        IDataResult<List<Food>> GetAll();
        IDataResult<Food> GetById(int foodId);
        IResult Update(UpdateFoodRequest updateFoodRequest);
        IDataResult<List<GetFoodDetails>> GetFoodDetails();
    }
}
