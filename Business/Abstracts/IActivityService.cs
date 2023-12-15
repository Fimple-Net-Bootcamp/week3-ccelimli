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
    public interface IActivityService
    {
        IResult Add(AddActiviteRequest addActiviteRequest);
        IResult Delete(int activityId);
        IDataResult<List<GetAllActivityResponse>> GetAll();
        IDataResult<GetAllActivityResponse> GetById(int activityId);
        IResult Update(UpdateActiviyRequest updateActiviyRequest);
        IDataResult<List<GetAllActivityResponse>> GetAllDetail();
    }
}
