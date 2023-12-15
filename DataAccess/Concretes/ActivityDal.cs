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
    public class ActivityDal : EntityRepositoryBase<Activity, PetCareContext>, IActivityDal
    {
        public List<GetAllActivityResponse> GetAllDetails()
        {
            using (PetCareContext context = new PetCareContext())
            {
                var GetAllActivityResponse = from activity in context.Activities
                                        join pet in context.Pets
                                        on activity.PetId equals pet.Id
                                        where activity.PetId == pet.Id
                                        select new GetAllActivityResponse
                                        {
                                            Type = activity.Type,
                                            Note = activity.Note,
                                            getAllPetResponse= (from pet in context.Pets
                                                                join user in context.Users
                                                                on pet.UserId equals user.Id
                                                                where pet.UserId == user.Id
                                                                select new GetAllPetResponse
                                                                {
                                                                    PetName = pet.PetName,
                                                                    PetBreed = pet.PetBreed,
                                                                    PetAge = pet.PetAge,
                                                                    PetGender = pet.Gender
                                                                }).ToList()

                                        };
                return GetAllActivityResponse.ToList();
            }
        }
    }
}
