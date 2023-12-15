using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Responses
{
    public class GetAllPetDetails
    {
        public string PetName{ get; set; }
        public string PetBreed { get; set; }
        public short PetAge{ get; set; }
        public char Gender { get; set; }
        public string UserFirstName{ get; set;}
        public string UserLastName { get; set;}
        public string UserPhoneNumber { get; set;}
        public bool Vaccinated{ get; set; }
        public short Weight{ get; set; }
        public bool Sterilize { get; set; }
    }
}
