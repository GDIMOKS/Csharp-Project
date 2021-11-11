using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class RegistrationCertificate
    {
        public Guid Id { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string Number { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime RequestDate { get; set; }
        public string RightHolder { get; set; }

    }
}
