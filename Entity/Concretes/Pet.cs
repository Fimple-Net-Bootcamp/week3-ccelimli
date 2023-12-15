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
    [Table(name:"Pets")]
    public class Pet : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set ; }
        [Column(name: "PetName")]
        public string PetName { get ; set; }
        [Column(name: "PetBreed")]
        public string PetBreed { get; set ; }
        [Column(name: "PetAge")]
        public short PetAge { get; set; }
        [Column(name: "Gender")]
        public char Gender { get; set; }
        [Column(name: "UserId")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? user { get; set; }
    }
}
