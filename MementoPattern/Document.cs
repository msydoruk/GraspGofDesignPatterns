using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Document : ICloneable
    {
        public Document(string name, string text)
        {
            Created = DateTime.UtcNow;
            Name = name;
            Text = text;
        }

        public string Name { get; set; }

        public string Text { get; set; }

        public DateTime Created { get; }

        public object Clone()
        {
            return new Document(Name, Text);
        }
    }
}
