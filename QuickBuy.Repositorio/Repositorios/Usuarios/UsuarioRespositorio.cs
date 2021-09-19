using QuickBuy.Dominio.Entidades.Usuarios;
using QuickBuy.Dominio.Interface.Repositorio.Usuarios;
using QuickBuy.Repositorio.Repositorios.Base;

namespace QuickBuy.Repositorio.Repositorios.Usuarios
{
    public class UsuarioRespositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRespositorio()
        {

        }
    }
}