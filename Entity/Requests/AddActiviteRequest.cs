using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class AddActiviteRequest
    {
        public string Type { get; set; }
        public string Note { get; set; }
        public int PetId { get; set; }
    }
}
