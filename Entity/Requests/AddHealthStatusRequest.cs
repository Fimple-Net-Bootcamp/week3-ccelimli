using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class AddHealthStatusRequest
    {
        public bool Vaccinated { get; set; }
        public short Weight { get; set; }
        public bool Sterilize { get; set; }
        public int PetId { get; set; }
    }
}
