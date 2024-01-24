using Domain.Model;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IExerciseRepository : IRepository<Exercise, Guid>
    
    {
        Task CreateAsync(Exercise exercise);
        Task UpdateAsync(Exercise exercise);
        Task DeleteAsync(Guid exerciseId);
        Task<Exercise> GetAsync(string name);
    }
}
