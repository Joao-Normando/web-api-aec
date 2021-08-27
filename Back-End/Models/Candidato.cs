using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace aec_gama_api.Models
{
  [Table("candidatos")]
  public class Candidato
  {
    [Key]
    [Column("id")]
    public int Id_Candidato { get;set; }

    [Column("nome", TypeName = "varchar")]
    [MaxLength(100)]
    [Required]
    public string Nome { get;set; }

    [Column("nascimento", TypeName = "varchar")]
    [MaxLength(15)]
    public string Nascimento { get;set; }

    [Column("cep", TypeName = "varchar")]
    [MaxLength(50)]
    [Required]

    public string Cep {get; set; }

    [Column("logradouro", TypeName = "varchar")]
    [MaxLength(50)]
    [Required]
    public string Logradouro {get; set; }

    [Column("numero", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]
    public string Numero {get; set; }

    [Column("bairro", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]
    public string Bairro {get; set; }

    [Column("cidade", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]
    public string Cidade {get; set; }

    [Column("uf", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]
    public string UF {get; set; }

    [Column("telefone", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]

    public string Telefone {get; set; }

    [Column("email", TypeName = "varchar")]
    [MaxLength(10)]
    [Required]

    
    public string Email {get; set; }

    [Column("profissao_id")]
    [Required]
    [ForeignKey("ProfissaoID")]
    [JsonPropertyName("profissao_id")]

    public int ProfissaoID {get;set;}

    
    
  }
}