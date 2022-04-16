using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaApp.Models;

public class Filme
{
    [Key]
    public int id { get; set; }

    [Required(ErrorMessage = "O campo título é obrigatório!")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Tem que ter no mínimo 3 e no máximo 60 caracteres!")]
    [Display(Name = "Título")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O campo título é obrigatório!")]
    [DataType(DataType.DateTime, ErrorMessage = "Formato de data inválido!")]
    [Display(Name = "Data de lançamento!")]
    public DateTime DataLancamento { get; set; }

    [RegularExpression(@"^[A-Z]+[A-Za-z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido!")]
    [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
    [Display(Name = "Gênero")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "O campo valor é obrigatório!")]
    [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000!")]
    [Column("Valor", TypeName = "decimal(18,2)")]
    public Decimal Valor { get; set; }

    [Required(ErrorMessage = "O campo avaliação é obrigatório!")]
    [Range(0, 5, ErrorMessage = "Valor de 0 a 5!")]
    // [RegularExpression(@"^[0-5]*$",ErrorMessage = " Formato de avaliação inválido!")]
    [Display(Name = "Avaliação")]
    public int Avaliacao { get; set; }


}