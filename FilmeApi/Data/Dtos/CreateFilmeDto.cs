using System.ComponentModel.DataAnnotations;
namespace FilmeApi.Data.Dtos;

public class CreateFilmeDto
{
    //DTOs trazem diversas vantagens relacionadas a organização de código.Além disso, utilizando DTOs, conseguimos ter um maior controle em nossas requisições e respostas
    //Com DTOs podemos definir os parâmetros enviados de maneira isolada do nosso modelo do banco de dados.
    //Há parâmetros que não precisamos enviar, como por exemplo o id.Outro fator é que não estamos mais exponfo o nosso modelo do banco de dados.


    [Required(ErrorMessage = "O Título do filme é obrigatiório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Gênerodo filme é obrigatiório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
