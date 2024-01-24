using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Routine : AggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public string Description { get; private set; }
        private readonly List<Exercise> exercises = new List<Exercise>();
        public IReadOnlyList<Exercise> Exercises => exercises.AsReadOnly();

        public Routine(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }

        public void AddExercise(Exercise exercise)
        {
            exercises.Add(exercise);
        }
        // Otros métodos y lógica específica de la rutina
    }
}