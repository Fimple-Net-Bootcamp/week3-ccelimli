using AutoMapper;
using Entity.Concretes;
using Entity.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserRequest>();

        }
    }
}
