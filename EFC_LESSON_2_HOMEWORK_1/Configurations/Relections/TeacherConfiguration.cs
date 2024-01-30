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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {

            builder.HasMany(t => t.T_Cards)
                .WithOne()
                .HasForeignKey(t => t.Id_Teacher)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(d => d.Department)
                .WithMany()
                .HasForeignKey(d => d.Id_Dap)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
