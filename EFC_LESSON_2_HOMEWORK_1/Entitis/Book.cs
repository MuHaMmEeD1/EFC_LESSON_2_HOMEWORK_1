using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Entitis
{
    public class Book : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int Id_Themes { get; set; }
        public Theme Theme { get; set; }
        public int Id_Catagory { get; set; }
        public Categorle Categorle { get; set; }
        public int Id_Authors { get; set; }
        public Author Author { get; set; }
        public int Id_Press { get; set; }
        public Press Press { get; set; }
        public string? Comment { get; set; }
        public int Quantity { get; set; }


        public List<S_Card> S_Cards { get; set; }
        public List<T_Card> T_Cards { get; set; }



    }
}
