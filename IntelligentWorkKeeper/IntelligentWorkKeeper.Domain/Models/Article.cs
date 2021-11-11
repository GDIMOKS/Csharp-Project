using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string CollectionTitle { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int MagazineNumber { get; set; }
        public int Part { get; set; }
        public string ArticleType { get; set; }
    }
}
