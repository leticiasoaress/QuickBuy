using QuickBuy.Dominio.Entidades.Base;
using QuickBuy.Dominio.Entidades.Usuarios;
using QuickBuy.Dominio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades.Pedidos
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }     
        public DateTime DataPrevistaEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int IdFormaPagamento { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            if (!ItensPedido.Any())
            {
                AddError("Pedido não pode ficar sem itens.");
            }

            if (IdFormaPagamento <= 0)
            {
                AddError("Pedido não pode ficar sem itens.");
            }

            if (string.IsNullOrWhiteSpace(CEP))
            {
                AddError("CEP deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Estado))
            {
                AddError("Estado deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Cidade))
            {
                AddError("Cidade deve ser informada.");
            }

            if (string.IsNullOrWhiteSpace(Logradouro))
            {
                AddError("Logradouro deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Numero))
            {
                AddError("Numero deve ser informado.");
            }

            var validacaoFormaPagamento = FormaPagamento.Validate();
            if (validacaoFormaPagamento.Any())
            {
                AddListError(validacaoFormaPagamento);
            }
        }
    }
}