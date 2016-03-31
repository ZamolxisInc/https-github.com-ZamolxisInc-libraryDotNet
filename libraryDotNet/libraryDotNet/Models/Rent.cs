using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libraryDotNet.Models
{
    public class Rent
    {
        public int bookId { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string clasa { get; set; }
        public DateTime rentDate { get; set; }
        public DateTime backDate { get; set; }
        public bool returnet { get; set; }
    }
}
