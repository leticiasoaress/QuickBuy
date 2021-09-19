﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades.Pedidos;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido)
                   .IsRequired();

            builder.Property(p => p.DataPrevistaEntrega)
                   .IsRequired();

            builder.Property(p => p.CEP)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.Property(p => p.Cidade)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Estado)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Logradouro)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Numero)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.HasOne(p => p.FormaPagamento);
        }
    }
}