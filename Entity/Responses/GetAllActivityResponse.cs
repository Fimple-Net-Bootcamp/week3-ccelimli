using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Responses
{
    public class GetAllActivityResponse
    {
        public string Type { get; set; }
        public string Note { get; set; }
        public List<GetAllPetResponse> getAllPetResponse { get; set; }
    }
}
