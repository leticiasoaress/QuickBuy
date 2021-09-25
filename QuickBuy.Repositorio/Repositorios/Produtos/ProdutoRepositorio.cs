using QuickBuy.Dominio.Entidades.Produtos;
using QuickBuy.Dominio.Interface.Repositorio.Produtos;
using QuickBuy.Repositorio.Contexto;
using QuickBuy.Repositorio.Repositorios.Base;

namespace QuickBuy.Repositorio.Repositorios.Produtos
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRespositorio
    {
        public ProdutoRepositorio(QuickBuyContext context) 
            : base(context)
        {
        }
    }
}