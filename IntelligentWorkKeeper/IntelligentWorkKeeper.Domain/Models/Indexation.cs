using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class Indexation
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }

        // свойства навигации
        public int IntelligentWorkId { get; set; }
        public IntelligentWork IntelligentWork { get; set; }
    }
}
