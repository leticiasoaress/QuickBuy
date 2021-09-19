using QuickBuy.Dominio.Constantes;

namespace QuickBuy.Dominio.ValueObjects
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto 
        {
            get { return Id is TipoFormaPagamento.Boleto; }
        }

        public bool IsCartaoCredito
        {
            get { return Id is TipoFormaPagamento.CartaoCredito; }
        }

        public bool IsPix
        {
            get { return Id is TipoFormaPagamento.Pix; }
        }

        public bool IsNaoDefinido
        {
            get { return Id is TipoFormaPagamento.NaoDefinido; }
        }
    }
}