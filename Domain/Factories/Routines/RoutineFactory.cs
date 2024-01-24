using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories.Routines
{
    public class RoutineFactory : IRoutineFactory
    {
        public Routine CreateRoutine(string name, string descripcion)
        {
            return new Routine(name,descripcion);
        }
    }
}
