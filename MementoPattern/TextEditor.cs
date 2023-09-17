using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class TextEditor
    {
        private Document document;

        public TextEditor(Document document)
        {
            this.document = document;
        }

        public void ModifyDocument(string name, string text)
        {
            document.Name = name;
            document.Text = text;
        }

        public IDocumentMemento Save()
        {
            return new DocumentMemento(document);
        }

        public void Restore(IDocumentMemento documentMemento)
        {
            document = documentMemento.GetDocument();
        }

        public void PrintCurrentDocument()
        {
            Console.WriteLine($"Name:{document.Name}," +
                              $"Text:{document.Text}," +
                              $"Modification Date:{document.Created}");
        }
    }
}
