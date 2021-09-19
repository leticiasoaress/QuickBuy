using QuickBuy.Dominio.Entidades.Produtos;
using QuickBuy.Repositorio.Repositorios.Base;

namespace QuickBuy.Repositorio.Repositorios.Produtos
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio()
        {

        }
    }
}