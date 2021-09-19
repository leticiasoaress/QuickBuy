using System.Collections.Generic;

namespace QuickBuy.Dominio.ValueObjects
{
    public class Endereco
    {
        private List<string> _errorMessages => _errorMessages ?? new List<string>();

        public int Id { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }

        public List<string> Validate()
        {
            if (string.IsNullOrWhiteSpace(CEP))
            {
                _errorMessages.Add("CEP deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Estado))
            {
                _errorMessages.Add("Estado deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Cidade))
            {
                _errorMessages.Add("Cidade deve ser informada.");
            }

            if (string.IsNullOrWhiteSpace(Logradouro))
            {
                _errorMessages.Add("Logradouro deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Numero))
            {
                _errorMessages.Add("Numero deve ser informado.");
            }

            return _errorMessages;
        }
    }
}