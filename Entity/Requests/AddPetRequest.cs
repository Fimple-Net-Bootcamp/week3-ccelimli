using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class AddPetRequest
    {
        public string PetName { get; set; }
        public string petBreed { get; set; }
        public short petAge { get; set; }
        public short Gender { get; set; }
        public int UserId { get; set; }
    }
}
