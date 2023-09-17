using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class DocumentCareTaker
    {
        private readonly TextEditor textEditor;
        private int maxVerion = 0;
        private readonly Dictionary<int, IDocumentMemento> documents = new();

        public DocumentCareTaker(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }

        public void Backup()
        {
            maxVerion += 1;
            documents.Add(maxVerion, textEditor.Save());
        }

        public void Restore(int version)
        {
            if (documents.ContainsKey(version))
            {
                textEditor.Restore(documents[version]);
            }
        }

        public void PrintHistory()
        {
            foreach (var document in documents)
            {
                Console.WriteLine($"Version:{document.Key}," +
                                  $"Name:{document.Value.GetDocument().Name}," +
                                  $"Text:{document.Value.GetDocument().Text}," +
                                  $"Modification Date:{document.Value.GetModificationDate()}");
            }
        }
    }
}
