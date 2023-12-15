using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class FoodDal : EntityRepositoryBase<Food, PetCareContext>, IFoodDal
    {
        public List<GetFoodDetails> GetDetail()
        {
            using (PetCareContext context = new PetCareContext())
            {
                var GetDetail = from food in context.Foods
                                join healthStatus in context.HealthStatuses
                                on food.HealthStatusId equals healthStatus.Id
                                join pet in context.Pets
                                on healthStatus.PetId equals pet.Id
                                where food.HealthStatusId == healthStatus.Id
                                select new GetFoodDetails
                                {
                                    Name = food.Name,
                                    Type = food.Type,
                                    AgeAppropriateness = food.AgeAppropriateness,
                                    SterlieFood = food.SterlieFood,
                                    PetName = pet.PetName,
                                    
                                };
                return GetDetail.ToList();
            }
        }
    }
}
