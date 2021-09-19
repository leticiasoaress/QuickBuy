using QuickBuy.Dominio.Enumerator;

namespace QuickBuy.Dominio.ValueObjects
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto 
        {
            get { return Id is (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool IsCartaoCredito
        {
            get { return Id is (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        public bool IsPix
        {
            get { return Id is (int)TipoFormaPagamentoEnum.Pix; }
        }

        public bool IsNaoDefinido
        {
            get { return Id is (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}