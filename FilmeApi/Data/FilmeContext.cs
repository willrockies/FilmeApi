using FilmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data;


// utilizar o DbContext é uma das principais maneiras de acessar o banco de dados.
// grande vantagem de utilizar esse recurso.
// Abstrair a lógica de acesso ao banco de dados. Dessa maneira, nosso esforço de acessar o banco de dados é reduzido.
public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {
        
    }

    public DbSet<Filme> Filmes { get; set; }
}
