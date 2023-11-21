using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTest1.Data
{
    internal class Author
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string? Country { get; set; }
        public ICollection<Books>? Book { get; set; }
        public override string ToString()
        {
            return Name;
        }

    }
}
