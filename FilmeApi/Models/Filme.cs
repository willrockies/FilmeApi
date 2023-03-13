using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class Filme
{
    [Required(ErrorMessage = "O Título do filme é obrigatiório")]
    public string Titulo { get; set; }
    [Required (ErrorMessage = "O Gênerodo filme é obrigatiório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70,600, ErrorMessage ="A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
