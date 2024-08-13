using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.Infraestrutura.Db;
public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSetings;
    public DbContexto(IConfiguration configuracaoAppSetings)
    {
            _configuracaoAppSetings = configuracaoAppSetings;
    }
    public DbSet<Administrador> Administradores {get; set;} = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {


            var stringConexao = _configuracaoAppSetings.GetConnectionString("mysql")?.ToString();
            if(!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(stringConexao, 
                ServerVersion.AutoDetect(stringConexao)
             );
            }
       
        }
    }
}