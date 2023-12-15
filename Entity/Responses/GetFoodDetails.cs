using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Responses
{
    public class GetFoodDetails
    {
         public string Name { get; set; }
        public string Type { get; set; }
        public short AgeAppropriateness { get; set; }
        public bool SterlieFood { get; set; }
        public string PetName { get; set; }
    }
}
