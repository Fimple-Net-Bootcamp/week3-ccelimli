using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class UpdateHealthStatusRequest
    {
        public int Id { get; set; }
        public bool Vaccinated { get; set; }
        public short Weight { get; set; }
        public bool Sterilize { get; set; }
        public int PetId { get; set; }
    }
}
