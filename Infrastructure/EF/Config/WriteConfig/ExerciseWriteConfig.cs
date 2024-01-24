using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Config.WriteConfig
{
    internal class ExerciseWriteConfig : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercise");
            builder.Property(x => x.Id).HasColumnName("exerciseId");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            // Configuración de la propiedad de video
            builder.Property(x => x.VideoUrl).HasColumnName("videoUrl");

            // Otras configuraciones y propiedades específicas del ejercicio
        }
    }

}
