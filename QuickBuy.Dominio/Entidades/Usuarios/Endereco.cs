using QuickBuy.Dominio.Entidades.Base;

namespace QuickBuy.Dominio.Entidades.Usuarios
{
    public class Endereco : Entidade
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public int IdUsuario { get; set; }

        public override void Validate()
        {
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
        }
    }
}