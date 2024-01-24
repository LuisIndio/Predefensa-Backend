using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Exercise : AggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<MuscleGroup> MuscleGroups { get; private set; } = new List<MuscleGroup>();
        public List<string> PhotoUrls { get; private set; } = new List<string>(); // Lista de URL de fotos
        public string VideoUrl { get; private set; }

        public Exercise(string name, string description, string videoUrl)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            VideoUrl = videoUrl;
        }

        public void AddMuscleGroup(MuscleGroup muscleGroup)
        {
            MuscleGroups.Add(muscleGroup);
        }

        public void AddPhotoUrl(string photoUrl)
        {
            PhotoUrls.Add(photoUrl);
        }

        public Exercise() { }
        // Otros métodos y lógica específica del ejercicio
    }
}
