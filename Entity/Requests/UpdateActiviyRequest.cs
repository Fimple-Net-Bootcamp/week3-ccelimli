using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class UpdateActiviyRequest
    {

        public int Id { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public int PetId { get; set; }
    }
}
