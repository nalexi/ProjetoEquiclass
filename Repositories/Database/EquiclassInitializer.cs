using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Database
{
    public class EquiclassInitializer : DropCreateDatabaseIfModelChanges<EquiclassContext>
    {
        protected override void Seed(EquiclassContext context)
        {
            context.Equiclasses.Add(new Equiclass()
            {
                Nome = "Equiclass",
                Cnpj = "123",
                RegistroAtivo = true
            });
            base.Seed(context);
        }
    }
}
