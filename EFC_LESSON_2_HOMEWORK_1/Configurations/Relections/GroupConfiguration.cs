using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFC_LESSON_2_HOMEWORK_1.Entitis;

using System.Threading.Tasks;

namespace EFC_LESSON_2_HOMEWORK_1.Configurations.Relections
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasOne(b => b.Facultie)
                .WithMany()
                .HasForeignKey(b => b.Id_Facultiy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
