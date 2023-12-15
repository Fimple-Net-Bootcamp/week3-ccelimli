using Entity.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    [Table(name:"Users")]
    public class User:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "Id")]
        public int Id { get; set; }
        [Column(name: "FirstName")]
        public string FirstName { get; set; }
        [Column(name: "LastName")]
        public string LastName { get; set; }
        [Column(name: "Email")]
        public string Email { get; set; }
        [Column(name: "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}
