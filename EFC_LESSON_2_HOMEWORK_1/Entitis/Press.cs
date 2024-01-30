using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Entitis
{
    public class Press : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
