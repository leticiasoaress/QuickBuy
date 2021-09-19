using QuickBuy.Dominio.Entidades.Base;
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
        public int IdUsuario { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }

        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }

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

            var validacaoEndereco = Endereco.Validate();
            if (validacaoEndereco.Any())
            {
                AddListError(validacaoEndereco);
            }

            var validacaoFormaPagamento = FormaPagamento.Validate();
            if (validacaoFormaPagamento.Any())
            {
                AddListError(validacaoFormaPagamento);
            }
        }
    }
}