using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Entitis
{
    public class S_Card : BaseEntity
    {
        public int Id { get; set; }


        public int Id_Student {  get; set; }
        public Student Student { get; set; }

        public int Id_Book { get; set; }
        public Book Book { get; set; }

        public int Id_Lib {  get; set; }
        public Lib Lib { get; set; }
        public DateTime DateOut {  get; set; }
        public DateTime? DateIn { get; set; }
        public S_Card() { DateOut = DateTime.Now; }
    }
}
