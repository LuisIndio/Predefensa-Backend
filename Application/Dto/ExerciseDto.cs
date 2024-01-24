using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class ExerciseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MuscleGroupDto> MuscleGroups { get; set; } = new List<MuscleGroupDto>();
        public List<string> Photos { get; set; } = new List<string>();
        public string VideoUrl { get; set; }
    }

}
