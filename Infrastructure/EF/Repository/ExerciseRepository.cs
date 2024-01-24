using Domain.Model;
using Domain.Repositories;
using Infrastructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Repository
{
    internal class ExerciseRepository : IExerciseRepository
    {
        private readonly WriteDbContext _writeDbContext;

        public ExerciseRepository(WriteDbContext writeDbContext)
        {
            _writeDbContext = writeDbContext;
        }

        public async Task CreateAsync(Exercise exercise)
        {
            await _writeDbContext.Exercises.AddAsync(exercise);
        }

        public async Task DeleteAsync(Guid exerciseId)
        {
            var exercise = await _writeDbContext.Exercises.FindAsync(exerciseId);
            if (exercise != null)
            {
                _writeDbContext.Exercises.Remove(exercise);
                await _writeDbContext.SaveChangesAsync();
            }
        }

        public async Task<Exercise?> FindByIdAsync(Guid id)
        {
            return await _writeDbContext.Exercises.FindAsync(id);
        }

        // Puedes implementar el método GetAsync según tus necesidades específicas
        // Aquí hay un ejemplo básico:
        public async Task<Exercise> GetAsync(string exerciseName)
        {
            return await _writeDbContext.Exercises
                .Where(x => x.Name == exerciseName)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Exercise exercise)
        {
            _writeDbContext.Exercises.Update(exercise);
            await _writeDbContext.SaveChangesAsync();
        }
    }

}
