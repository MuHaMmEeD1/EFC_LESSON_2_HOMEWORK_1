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
    public class LibColumnConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {
            
            builder.Property(l=>l.FirstName).IsRequired().HasColumnType("nvarchar(30)");
            builder.Property(l=>l.LastName).IsRequired().HasColumnType("nvarchar(30)");

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();

            builder.Ignore(l => l.S_Cards);
            builder.Ignore(l => l.T_Cards);
        }
    }
}
