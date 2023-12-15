using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Responses
{
    public class GetAllPetResponse
    {
        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public short PetAge { get; set; }
        public char PetGender { get; set; }
    }
}
