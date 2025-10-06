using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_prog1
{
    internal class Libro
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Status { get; set; }
        public DateTime PublishedDate { get; set; }
        public string[] Authors { get; set; }
        public string[] Categories { get; set; }
    }
}
