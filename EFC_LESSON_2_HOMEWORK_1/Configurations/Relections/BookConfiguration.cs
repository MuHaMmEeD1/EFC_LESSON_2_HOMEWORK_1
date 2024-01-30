using EFC_LESSON_2_HOMEWORK_1.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Configurations.Relections
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.HasOne(t => t.Theme)
                .WithMany()
                .HasForeignKey(t=>t.Id_Themes)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(a => a.Author)
                .WithMany()
                .HasForeignKey(a => a.Id_Authors)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(p => p.Press)
                .WithMany()
                .HasForeignKey(p => p.Id_Press)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Categorle)
                .WithMany()
                .HasForeignKey(c => c.Id_Catagory)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.S_Cards)
                .WithOne()
                .HasForeignKey(s=>s.Id_Book)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasMany(t => t.T_Cards)
                .WithOne()
                .HasForeignKey(t=>t.Id_Book)
                .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
