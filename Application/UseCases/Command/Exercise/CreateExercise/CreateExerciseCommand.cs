using Application.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Command.Exercise.CreateExercise
{
    public record CreateExerciseCommand : IRequest<Guid>
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public List<MuscleGroupDto> MuscleGroups { get; init; } = new List<MuscleGroupDto>();
        public List<string> Photos { get; init; } = new List<string>();
        public string VideoUrl { get; init; }

        public CreateExerciseCommand(string name, string description,string videoUrl)
        {
            Name = name;
            Description = description;
            VideoUrl = videoUrl;
        }

        public CreateExerciseCommand(string name, string description, List<MuscleGroupDto> muscleGroups, List<string> photos, string videoUrl)
        {
            Name = name;
            Description = description;
            MuscleGroups = muscleGroups;
            Photos = photos;
            VideoUrl = videoUrl;
        }
    }


}
