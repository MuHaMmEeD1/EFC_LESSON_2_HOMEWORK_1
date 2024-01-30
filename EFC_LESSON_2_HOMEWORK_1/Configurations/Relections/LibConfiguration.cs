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
    public class LibConfiguration : IEntityTypeConfiguration<Lib>
    {
        public void Configure(EntityTypeBuilder<Lib> builder)
        {

            builder.HasMany(t => t.T_Cards)
                .WithOne()
                .HasForeignKey(t=>t.Id_Lib)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.S_Cards)
                .WithOne()
                .HasForeignKey(s=>s.Id_Lib)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
