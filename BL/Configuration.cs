using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF;
using Model;
using Ninject.Modules;
namespace BL
{
    class Configuration : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Employee>>().To<EntityRepository<Employee>>().InSingletonScope();
        }
    }
}
