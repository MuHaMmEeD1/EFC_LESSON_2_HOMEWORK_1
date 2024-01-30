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
    public class TeacherColumnConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.Property(t => t.FirstName).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(t => t.LastName).HasColumnType("nvarchar(30)").IsRequired();

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();

            builder.Ignore(t=>t.T_Cards);
            builder.Ignore(t=>t.Department);

        }
    }
}
