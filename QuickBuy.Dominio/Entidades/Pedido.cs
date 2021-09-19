using QuickBuy.Dominio.ValueObjects;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public int IdFormaPagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        ICollection<ItemPedido> ItensPedido { get; set; }
    }
}