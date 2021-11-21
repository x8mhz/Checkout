using System;
using System.Text.RegularExpressions;

namespace Checkout.Domain.Entities
{
    public class Document
    {
        protected Document()
        {

        }

        public Document(string number)
        {
            Number = number;

            if (Validate(number)) throw new Exception("Document invalid");
        }

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
