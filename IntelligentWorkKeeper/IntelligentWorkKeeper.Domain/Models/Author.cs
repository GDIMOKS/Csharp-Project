using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentWorkKeeper.Domain.Models
{
    public class Author
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PatronymicName { get; set; }
        public string ShortFirstName { get; set; }
        public string ShortPatronymicName { get; set; }
        public int NumberInList { get; set; }

        // свойства навигации
        //public List<IntelligentWork> IntelligentWorks { get; set; }
        public int IntelligentWorkId { get; set; }
        public IntelligentWork IntelligentWork { get; set; }
    }
}
