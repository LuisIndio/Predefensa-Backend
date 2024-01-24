using Domain.Model;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRoutineRepository : IRepository<Routine,Guid>
    {
        Task CreateAsync(Routine routine);
        Task UpdateAsync(Routine routine);
        Task DeleteAsync(Guid routineId);
        Task<Routine> GetAsync(string name, string descripcion);
    }
}
