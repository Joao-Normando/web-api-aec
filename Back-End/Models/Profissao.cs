using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aec_gama_api.Models
{
    [Table("profissoes")]
    public class Profissao
    {
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("descricao", TypeName ="varchar")]
        [MaxLength(45)]
        [Required]

        public string Descricao{get; set;}

        public ICollection <Candidato> candidatos {get; set;} 
        
    }
}