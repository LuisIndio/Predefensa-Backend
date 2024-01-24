using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class MuscleGroup : AggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public MuscleGroup(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public MuscleGroup() { }
        // Otros métodos y lógica específica del grupo muscular
    }
}
