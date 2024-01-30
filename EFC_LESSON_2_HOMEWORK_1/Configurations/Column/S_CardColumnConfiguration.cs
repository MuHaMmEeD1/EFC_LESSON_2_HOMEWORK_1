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
    public class S_CardColumnConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {

            builder.Property(sc => sc.DateOut).IsRequired().HasColumnType("Date");
            builder.Property(sc => sc.DateIn).IsRequired(false).HasColumnType("Date");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();

            builder.Ignore(sc=>sc.Book);
            builder.Ignore(sc=>sc.Student);
            builder.Ignore(sc=>sc.Lib);



        }
    }
}
