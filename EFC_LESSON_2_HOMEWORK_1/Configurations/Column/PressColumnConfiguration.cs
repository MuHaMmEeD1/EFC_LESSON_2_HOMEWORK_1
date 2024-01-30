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
    public class PressColumnConfiguration : IEntityTypeConfiguration<Press>
    {
        public void Configure(EntityTypeBuilder<Press> builder)
        {
            
            builder.Property(p=> p.Name).IsRequired().HasColumnType("nvarchar(30)");


            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();

            builder.Ignore(p=>p.Books);
        }
    }
}
