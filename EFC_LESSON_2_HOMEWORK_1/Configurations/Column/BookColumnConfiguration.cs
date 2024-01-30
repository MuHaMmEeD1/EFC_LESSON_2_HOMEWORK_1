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
    public class BookColumnConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Comment).HasColumnType("nvarchar(max)").IsRequired(false);
            builder.Property(b => b.Name).HasColumnType("nvarchar(100)");
            builder.HasIndex(b=>b.Name).IsUnique(true);

            builder.Ignore(b=>b.S_Cards);
            builder.Ignore(b=>b.T_Cards);
            builder.Ignore(b=>b.Press);
            builder.Ignore(b=>b.Theme);
            builder.Ignore(b=>b.Author);
            builder.Ignore(b=>b.Categorle);


        }
    }
}
