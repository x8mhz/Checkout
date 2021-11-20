using System;
using System.Text.RegularExpressions;

namespace Checkout.Domain.Entities
{
    public class Document
    {
        public Document(string number)
        {
            Id = Guid.NewGuid();    
            Number = number;

            if (Validate(number)) throw new Exception("Document invalid");
        }

        public Guid Id { get; private set; }
        public string Number { get; private set; }

        public bool Validate(string doc)
        {
            if (doc == null) return false;
            var document = CleanDocumentation(doc);
            if (document.Length != 11) return false;

            return true;
        }

        private string CleanDocumentation(string document)
        {
            Regex numberOnly = new Regex(@"[^\d]");
            return numberOnly.Replace(document, "");
        }
    }
}
