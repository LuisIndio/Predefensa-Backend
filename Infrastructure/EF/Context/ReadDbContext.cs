using Infrastructure.EF.ReadModel;
using Infrastructure.EF.Config.ReadConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<UserReadModel> Users { get; set; }
        public virtual DbSet<ExerciseReadModel> Exercise { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<UserReadModel>(new UserReadConfig());
            modelBuilder.ApplyConfiguration<ExerciseReadModel>(new ExerciseReadConfig());

        }
    }
}
