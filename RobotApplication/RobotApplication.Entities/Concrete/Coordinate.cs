using RobotApplication.Entities.Abstract;
using System.Collections.Generic;

namespace RobotApplication.Entities.Concrete
{
    public class Coordinate
        : ICoordinate
    {
        public Coordinate()
        {
            RobotList = new List<Robot>();
        }

        public int X { get; set; }
        public int Y { get; set; }
        private List<Robot> RobotList { get; set; }

        public void AddRobotsToCoordinate(Robot robot)
        {
            RobotList.Add(robot);
        }

        public void CompareRobotLocation()
        {
            foreach (var robot in RobotList)
            {
                robot.CompareRobotLocation(X, Y);
            }
        }

        public List<Robot> GetRobotList()
        {
            return RobotList;
        }

        public void SetCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
