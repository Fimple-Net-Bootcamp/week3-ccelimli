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
    public class PetDal : EntityRepositoryBase<Pet, PetCareContext>, IPetDal
    {
        public List<GetAllPetDetails> GetAllPetDetails()
        {
            using (PetCareContext context = new PetCareContext())
            {
                var GetAllPetDetails = from pet in context.Pets
                                       join user in context.Users
                                       on pet.UserId equals user.Id
                                       join activity in context.Activities
                                       on pet.Id equals activity.PetId
                                       join healthStatus in context.HealthStatuses
                                       on pet.Id equals healthStatus.PetId
                                       select new GetAllPetDetails
                                       {
                                           PetName = pet.PetName,
                                           PetBreed = pet.PetBreed,
                                           PetAge = pet.PetAge,
                                           Gender = pet.Gender,
                                           UserFirstName = user.FirstName,
                                           UserLastName = user.LastName,
                                           UserPhoneNumber = user.PhoneNumber,
                                           Weight = healthStatus.Weight,
                                           Vaccinated = healthStatus.Vaccinated,
                                           Sterilize = healthStatus.Sterilize,
                                       };
            return GetAllPetDetails.ToList();
        }
    }
}
}
