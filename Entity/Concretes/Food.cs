using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    [Table(name:"Foods")]
    public class Food:IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Name")]
        public string Name { get; set; }
        [Column(name: "Type")]  
        public string Type { get; set; }
        [Column(name: "AgeAppropriateness")]
        public short AgeAppropriateness { get; set; }

        [Column(name: "SterileFood")]
        public bool SterlieFood { get; set; }
        [Column(name: "HealthStatusId")]
        public int HealthStatusId { get; set; }
    }
}
