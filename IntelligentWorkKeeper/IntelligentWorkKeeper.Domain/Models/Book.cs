using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public int Edition { get; set; }
        public string EditionType { get; set; }
        public string BookType { get; set; }

    }
}
