using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades.Base
{
    public abstract class Entidade
    {
        private List<string> _errorMessages => _errorMessages ?? new List<string>();

        protected bool IsValid() => !_errorMessages.Any();
        protected void ClearMessages() => _errorMessages.Clear();     
        protected void AddError(string error) => _errorMessages.Add(error);
        protected void AddListError(List<string> error) => _errorMessages.AddRange(error);

        public string GetErrorMessages()
        {
            return string.Join(". ", _errorMessages);
        }

        public abstract void Validate();
    }
}