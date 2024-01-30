using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Entitis
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id_Group { get; set; }
        public Group Group { get; set; }
        public string Term { get; set; }

        public List<S_Card> S_Cards { get; set; }
        
    }
}
