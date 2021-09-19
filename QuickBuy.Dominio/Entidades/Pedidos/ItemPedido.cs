using QuickBuy.Dominio.Entidades.Base;

namespace QuickBuy.Dominio.Entidades.Pedidos
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (IdProduto <= 0)
            {
                AddError("Não foi identificado qual a referência do produto.");
            }
                
            if (Quantidade <= 0)
            {
                AddError("Quantidade inválida.");
            }              
        }
    }
}