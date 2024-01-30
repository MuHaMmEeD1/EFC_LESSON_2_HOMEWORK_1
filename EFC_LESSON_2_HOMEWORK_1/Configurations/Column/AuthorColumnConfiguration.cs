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
    public class AuthorColumnConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();
            builder.Property(a => a.FirstName).IsRequired().HasColumnType("nvarchar(30)");
            builder.Property(a => a.LastName).IsRequired().HasColumnType("nvarchar(30)");

            builder.Ignore(a => a.Books);

        }
    }
}
