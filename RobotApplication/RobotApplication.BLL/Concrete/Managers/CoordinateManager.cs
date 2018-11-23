using RobotApplication.BLL.Abstract;
using RobotApplication.Entities.Abstract;
using RobotApplication.Entities.Concrete;
using System.Collections.Generic;

namespace RobotApplication.BLL.Concrete.Managers
{
    public class CoordinateManager
        : ICoordinateService
    {
        private readonly ICoordinate _coordinate;

        public CoordinateManager(ICoordinate coordinate)
        {
            _coordinate = coordinate;
        }

        public void SetCoordinate(int x, int y)
        {
            _coordinate.SetCoordinate(x, y);
        }

        public void AddRobotsToCoordinate(Robot robot)
        {
            _coordinate.AddRobotsToCoordinate(robot);
        }

        public void SetMovementDirections(Robot robot, List<string> movementDirections)
        {
            //Burada try-catch olacak
            bool isError = false;
            foreach (var directions in movementDirections)
            {
                if (!(directions == "L" || directions == "R" || directions == "M"))
                {
                    isError = true;
                }
            }

            if (!isError)
            {
                robot.SetMovementDirections(movementDirections);
            }
        }

        public void MoveTheRobot()
        {
            foreach (var robot in GetRobotList())
            {
                robot.MoveTheRobot();
            }
        }

        public List<Robot> GetRobotList()
        {
            return _coordinate.GetRobotList();
        }

        public void CompareRobotLocation()
        {
            _coordinate.CompareRobotLocation();
        }
    }
}
