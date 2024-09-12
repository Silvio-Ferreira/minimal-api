using minimal_api.Dominio.Entidades;
using minimal_api.DTOs;

namespace minimal_api.Dominio.Interfaces;

public interface IAdministradorServico{
    Administrador? Login(LoginDTO loginDTO);
    Administrador? Incluir(Administrador administrador);
    Administrador? BuscaPorId(int  id);
    List<Administrador> Todos(int?  pagina);


}