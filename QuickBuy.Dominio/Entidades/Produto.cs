namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                AddError("Nome do produto não foi informado.");
            }
              
            if (string.IsNullOrWhiteSpace(Descricao))
            {
                AddError("Descrição não foi informado.");
            }
        }
    }
}