using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Dominio.Constantes
{
    public class TipoFormaPagamento
    {
        public const int Boleto = 1;
        public const int CartaoCredito = 2;
        public const int Pix = 3;

        public static readonly ICollection<int> Validos
            = new ReadOnlyCollection<int>(
                new List<int>
                {
                    Boleto,
                    CartaoCredito,
                    Pix
                });
    }
}