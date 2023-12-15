using Core.Utilities.Results.Abstracts;
using Entity.Concretes;
using Entity.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IHealthService
    {
        IResult Add(AddHealthStatusRequest addHealthStatusRequest);
        IResult Delete(int healthStatusId);
        IDataResult<List<HealthStatus>> GetAll();
        IDataResult<HealthStatus> GetById(int healthStatusId);
        IResult Update(UpdateHealthStatusRequest updateHealthStatusRequest);
    }
}
