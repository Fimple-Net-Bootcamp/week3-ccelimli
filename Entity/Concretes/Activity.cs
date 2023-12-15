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
    [Table(name:"Activities")]
    public class Activity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "Type")]
        public string Type { get ; set; }
        [Column(name: "Note")]
        public string Note { get ; set; }
        [Column(name: "PetId")]
        public int PetId { get ; set ; }
    }
}
