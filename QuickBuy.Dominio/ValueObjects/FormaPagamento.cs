using QuickBuy.Dominio.Constantes;
using System.Collections.Generic;

namespace QuickBuy.Dominio.ValueObjects
{
    public class FormaPagamento
    {
        private List<string> _errorMessages => _errorMessages ?? new List<string>();

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto => Id is TipoFormaPagamento.Boleto;
        public bool IsCartaoCredito => Id is TipoFormaPagamento.CartaoCredito;
        public bool IsPix => Id is TipoFormaPagamento.Pix;

        public List<string> Validate()
        {
            if (Id <= 0)
            {
                _errorMessages.Add("Não foi informado a forma de pagamento.");
            }

            if (!TipoFormaPagamento.Validos.Contains(Id))
            {
                _errorMessages.Add("Tipo de pagamento inválido.");
            }
            return _errorMessages;
        }
    }
}