using System;
using System.Collections.Generic;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class IntelligentWork
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Type { get; set; }
        public string DOI { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string GRNTI { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }


        // свойства навигации

        public List<Author> Authors { get; set; }
        public List<Indexation> Indexations { get; set; }
        public List<KeyWord> KeyWords { get; set; }

    }
}
