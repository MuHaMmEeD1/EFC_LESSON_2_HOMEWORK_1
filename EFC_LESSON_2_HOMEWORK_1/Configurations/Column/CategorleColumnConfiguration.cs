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
    public class CategorleColumnConfiguration : IEntityTypeConfiguration<Categorle>
    {
        public void Configure(EntityTypeBuilder<Categorle> builder)
        {
            builder.Property(c=>c.Name).HasColumnType("nvarchar(30)").IsRequired();
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();







        }
    }
}
