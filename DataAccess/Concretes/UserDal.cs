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
    public class UserDal : EntityRepositoryBase<User, PetCareContext>, IUserDal
    {
        public List<GetAllUserResponse> getAllUserResponses()
        {
            using (PetCareContext context= new PetCareContext())
            {
                var GetAllUserDetails = from user in context.Users
                                        join pet in context.Pets
                                        on user.Id equals pet.UserId
                                        where user.Id == pet.UserId
                                        select new GetAllUserResponse
                                        {
                                            FirstName = user.FirstName,
                                            LastName = user.LastName,
                                            Email = user.Email,
                                            PhoneNumber = user.PhoneNumber,
                                            pets = (from pet in context.Pets
                                                    where pet.UserId == user.Id
                                                    select new GetAllPetResponse
                                                    {
                                                        PetName = pet.PetName,
                                                        PetBreed = pet.PetBreed,
                                                        PetAge = pet.PetAge,
                                                        PetGender = pet.Gender
                                                    }).ToList()


                                        };
                return GetAllUserDetails.ToList();
            }
        }
    }
}
