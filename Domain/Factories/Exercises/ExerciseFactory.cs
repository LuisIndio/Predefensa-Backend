using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories.Exercises
{
    public class ExerciseFactory : IExerciseFactory
    {
        public Exercise CreateExercise(string name, string description, string videoUrl)
        {
            return new Exercise(name,description,videoUrl);
        }
    }
}
