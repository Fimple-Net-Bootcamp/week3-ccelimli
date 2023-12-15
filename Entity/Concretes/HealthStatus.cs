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
    [Table(name:"HealthStatuses")]
    public class HealthStatus:IEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Vaccinated")]
        public bool Vaccinated { get; set; }
        [Column(name: "Weight")]
        public short Weight { get; set; }
        [Column(name: "Sterilize")]
        public bool Sterilize { get; set; }
        [Column(name: "PetId")]
        public int PetId { get; set; }


       
    }
}
