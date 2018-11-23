using Ninject.Modules;
using RobotApplication.BLL.Abstract;
using RobotApplication.BLL.Concrete.Managers;
using RobotApplication.Entities.Abstract;
using RobotApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApplication.ConsoleUI
{
    public class NinjectBindings
         : NinjectModule
    {
        public override void Load()
        {
            Bind<ICoordinateService>().To<CoordinateManager>();
            Bind<ICoordinate>().To<Coordinate>();
        }
    }
}
