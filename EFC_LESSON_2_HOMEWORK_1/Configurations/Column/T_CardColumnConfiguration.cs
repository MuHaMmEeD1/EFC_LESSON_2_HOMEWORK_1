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
    public class T_CardColumnConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {

            builder.Property(tc => tc.DateOut).IsRequired().HasColumnType("Date");
            builder.Property(tc => tc.DateIn).IsRequired(false).HasColumnType("Date");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();

            builder.Ignore(sc => sc.Book);
            builder.Ignore(sc => sc.Teacher);
            builder.Ignore(sc => sc.Lib);

        }
    }
}
