using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class Filme
{
    //Mapeamento meu objeto para rodar em migration e criar sua tabela

    // as principais vantagens da utilização de migrations neste primeiro cenário de utilização.
    // Gerar o banco e tabelas de maneira programática. Com isso, não precisamos nos preocupar em detalhes de utilização do banco em questão.
    // A possibilidade de conferir se o que vamos criar no banco está conforme esperamos.
    // Ao gerar a migration, um código C# é criado, representando as operações que serão executadas no banco.

    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O Título do filme é obrigatiório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênerodo filme é obrigatiório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
