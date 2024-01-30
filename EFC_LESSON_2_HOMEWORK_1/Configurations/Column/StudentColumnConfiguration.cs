using EFC_LESSON_2_HOMEWORK_1.Entitis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Configurations.Column
{
    public class StudentColumnConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.Property(s => s.FirstName).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(s => s.LastName).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(s => s.Term).HasColumnType("nvarchar(30)").IsRequired();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();


            builder.Ignore(s => s.Group);
            builder.Ignore(s => s.S_Cards);


        }
    }
}
