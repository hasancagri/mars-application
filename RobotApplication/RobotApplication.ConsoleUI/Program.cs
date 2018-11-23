using Ninject;
using RobotApplication.BLL.Abstract;
using RobotApplication.Entities.Concrete;
using System.Collections.Generic;
using System.Reflection;

namespace RobotApplication.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());
            ICoordinateService _coordinateManager = _kernel.Get<ICoordinateService>();

            _coordinateManager.SetCoordinate(5, 5);
            Robot robot1 = new Robot(3, 3, "E");
            _coordinateManager.AddRobotsToCoordinate(robot1);
            _coordinateManager.SetMovementDirections(robot1,
                new List<string>() { "M", "M", "R", "M", "M", "R", "M", "R", "R", "M" });
            _coordinateManager.MoveTheRobot();
            _coordinateManager.CompareRobotLocation();
        }
    }
}
