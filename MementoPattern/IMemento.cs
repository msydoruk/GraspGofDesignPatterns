using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public interface IDocumentMemento
    {
        public Document GetDocument();

        public DateTime GetModificationDate();
    }
}
