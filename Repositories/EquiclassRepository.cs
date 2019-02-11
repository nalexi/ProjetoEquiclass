using Repositories.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EquiclassRepository
    {
        private readonly EquiclassContext _context;

        public EquiclassRepository()
        {
            _context = new EquiclassContext();
        }
    }
}
