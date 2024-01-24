using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories.Exercises
{
    public interface IExerciseFactory
    {
        Exercise CreateExercise(string name, string description, string videoUrl);
    }
}
