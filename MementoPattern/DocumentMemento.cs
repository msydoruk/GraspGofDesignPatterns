using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class DocumentMemento : IDocumentMemento
    {
        private readonly Document document;

        private readonly DateTime modificationDate;

        public DocumentMemento(Document document)
        {
            this.document = (Document?)document.Clone();
            modificationDate = DateTime.UtcNow;
        }

        public Document GetDocument()
        {
            return document;
        }

        public DateTime GetModificationDate()
        {
            return modificationDate;
        }
    }
}
