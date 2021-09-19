using QuickBuy.Dominio.Entidades.Pedidos;
using QuickBuy.Dominio.Interface.Repositorio.Pedidos;
using QuickBuy.Repositorio.Repositorios.Base;

namespace QuickBuy.Repositorio.Repositorios.Pedidos
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio()
        {

        }
    }
}