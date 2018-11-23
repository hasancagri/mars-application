using RobotApplication.Entities.Concrete;
using System.Collections.Generic;

namespace RobotApplication.BLL.Abstract
{
    public interface ICoordinateService
    {
        List<Robot> GetRobotList();
        void SetCoordinate(int x, int y);
        void AddRobotsToCoordinate(Robot robot);
        void SetMovementDirections(Robot robot, List<string> movementDirections);
        void CompareRobotLocation();
        void MoveTheRobot();
    }
}
