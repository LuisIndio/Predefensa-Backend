using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.ReadModel
{
    internal class ExerciseReadModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        // Descripción del ejercicio
        public string Description { get; set; }

        // Relación con grupos musculares
        public List<MuscleGroupReadModel> MuscleGroups { get; set; } = new List<MuscleGroupReadModel>();

        // Lista de URLs de fotos
        public List<string> PhotoUrls { get; set; } = new List<string>();

        // URL del video
        public string VideoUrl { get; set; }

        // Otros campos según sea necesario
    }

}
