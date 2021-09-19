﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                AddError("Email não foi informado.");
            }
                
            if (string.IsNullOrWhiteSpace(Senha))
            {
                AddError("Senha não foi informada.");
            }              
        }
    }
}