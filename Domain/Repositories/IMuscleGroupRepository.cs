using Domain.Model;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IMuscleGroupRepository : IRepository<MuscleGroup, Guid>
    {
        Task CreateAsync(MuscleGroup muscleGroup);
        Task UpdateAsync(MuscleGroup muscleGroup);
        Task DeleteAsync(Guid muscleGroupId);
        Task<MuscleGroup> GetAsync(string name);
    }
}
