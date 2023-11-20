using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TableTest1.Data
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Art { get; set; }
        public string Janr { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public Group Group;
    }
}
