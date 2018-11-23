using RobotApplication.Entities.Concrete;
using System.Collections.Generic;

namespace RobotApplication.Entities.Abstract
{
    public interface ICoordinate
    {
        void SetCoordinate(int x, int y);
        void AddRobotsToCoordinate(Robot robot);
        List<Robot> GetRobotList();
        void CompareRobotLocation();
    }
}
