using Domain.Factories.Exercises;
using Domain.Model;
using Domain.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Command.Exercise.CreateExercise
{
    internal class CreateExerciseHandler : IRequestHandler<CreateExerciseCommand, Guid>
    {
        private readonly IExerciseFactory _exerciseFactory;
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateExerciseHandler(IExerciseFactory exerciseFactory, IExerciseRepository exerciseRepository, IUnitOfWork unitOfWork)
        {
            _exerciseFactory = exerciseFactory;
            _exerciseRepository = exerciseRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateExerciseCommand request, CancellationToken cancellationToken)
        {
            var exercise = _exerciseFactory.CreateExercise(request.Name, request.Description,request.VideoUrl);

            // Agregar grupos musculares
            foreach (var muscleGroupDTO in request.MuscleGroups)
            {
                // Puedes tener una lógica específica para convertir MuscleGroupDTO a tu entidad MuscleGroup aquí
                var muscleGroup = new MuscleGroup(muscleGroupDTO.Name);
                exercise.AddMuscleGroup(muscleGroup);
            }

            // Agregar fotos
            foreach (var photoUrl in request.Photos)
            {
                exercise.AddPhotoUrl(photoUrl);
            }

            await _exerciseRepository.CreateAsync(exercise);
            await _unitOfWork.Commit();

            return exercise.Id;
        }
    }



}
