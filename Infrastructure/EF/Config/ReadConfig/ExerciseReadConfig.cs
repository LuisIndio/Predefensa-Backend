using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EF.ReadModel;

namespace Infrastructure.EF.Config.ReadConfig
{
    internal class ExerciseReadConfig : IEntityTypeConfiguration<ExerciseReadModel>
    {
        public void Configure(EntityTypeBuilder<ExerciseReadModel> builder)
        {
            builder.ToTable("ExerciseReadModel");  // Ajusta el nombre de la tabla según tus convenciones

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("exerciseId");

            builder.Property(x => x.Name).HasColumnName("name").IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").IsRequired();

            // Configuración de la relación con grupos musculares (si es una relación muchos a muchos)
            builder
                .HasMany(x => x.MuscleGroups)
                .WithMany()
                .UsingEntity(j => j.ToTable("ExerciseMuscleGroups"));

            // Configuración de la lista de URLs de fotos
            builder.OwnsMany(x => x.PhotoUrls, a =>
            {
                a.WithOwner().HasForeignKey("ExerciseId");
                a.Property<string>("PhotoUrl").IsRequired();
            });

            // Configuración de la URL del video
            builder.Property(x => x.VideoUrl).HasColumnName("videoUrl");

            // Otros campos según sea necesario

            // Puedes agregar más configuraciones según tus necesidades
        }
    }


}
