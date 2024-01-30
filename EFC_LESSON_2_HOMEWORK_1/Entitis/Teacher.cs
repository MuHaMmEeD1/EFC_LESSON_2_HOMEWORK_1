using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Entitis
{
    public class Teacher : BaseEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id_Dap { get; set; }

        public Department Department { get; set; }


        public List<T_Card> T_Cards { get; set; }

    }
}
