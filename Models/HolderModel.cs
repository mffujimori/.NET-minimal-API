using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Random_Forest.Models
{
    [Table("holder", Schema = "public")]
    public class Holder
    {
        [Key]//PK do banco
        [Column("id_holder")]
        public int IdHolder { get; set; }

        [Required] //notnull
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("address")]
        public string? Address { get; set; }

        [Column("cnpj")]
        public string? Cnpj { get; set; }

        [Column("phone")]
        public string? Phone { get; set; }
    }
}