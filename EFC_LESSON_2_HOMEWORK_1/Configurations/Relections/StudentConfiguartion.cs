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
    public class StudentConfiguartion : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasMany(s => s.S_Cards)
                .WithOne()
                .HasForeignKey(st => st.Id_Student)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
