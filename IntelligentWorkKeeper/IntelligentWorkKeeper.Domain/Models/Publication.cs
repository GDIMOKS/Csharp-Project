using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class Publication
    {
        public Guid Id { get; set; }
        public string Publisher { get; set; }
        public string UDK { get; set; }
        public int PageCount { get; set; }

    }
}
