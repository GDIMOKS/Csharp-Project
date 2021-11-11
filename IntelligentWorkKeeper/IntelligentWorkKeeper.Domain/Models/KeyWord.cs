using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class KeyWord
    {
        public Guid Id { get; set; }
        public string Word { get; set; }

        // свойства навигации
        public int IntelligentWorkId { get; set; }
        public IntelligentWork IntelligentWork { get; set; }
    }
}
