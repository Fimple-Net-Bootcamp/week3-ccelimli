using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Requests
{
    public class UpdateFoodRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public short AgeAppropriateness { get; set; }
        public bool SterlieFood { get; set; }
        public int HealthStatusId { get; set; }
    }
}
