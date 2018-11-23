using RobotApplication.Entities.Abstract;
using System.Collections.Generic;

namespace RobotApplication.Entities.Concrete
{
    public class Robot
        : IRobot
    {
        public Robot(int x, int y, string arrow)
        {
            X = x;
            Y = y;
            Arrow = arrow;
            MovementDirections = new List<string>();
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Arrow { get; set; }
        public List<string> MovementDirections { get; set; }

        public void CompareRobotLocation(int locationX, int locationY)
        {
            X = locationX < X ? locationX : X;
            Y = locationY < Y ? locationY : Y;
        }

        public void MoveTheRobot()
        {
            foreach (var direction in MovementDirections)
            {
                switch (direction)
                {
                    case "L":
                        TurnLeftTheRobot(direction);
                        break;
                    case "R":
                        TurnRightTheRobot(direction);
                        break;
                    default:
                        MoveTheRobot(direction);
                        break;
                }
            }
        }

        private void TurnLeftTheRobot(string direction)
        {
            switch (Arrow)
            {
                case "W":
                    Arrow = "S";
                    break;
                case "E":
                    Arrow = "N";
                    break;
                case "N":
                    Arrow = "W";
                    break;
                case "S":
                    Arrow = "E";
                    break;
            }
        }

        private void TurnRightTheRobot(string direction)
        {
            switch (Arrow)
            {
                case "W":
                    Arrow = "N";
                    break;
                case "E":
                    Arrow = "S";
                    break;
                case "N":
                    Arrow = "E";
                    break;
                case "S":
                    Arrow = "W";
                    break;
            }
        }

        private void MoveTheRobot(string direction)
        {
            switch (Arrow)
            {
                case "W":
                    X -= 1;
                    break;
                case "E":
                    X += 1;
                    break;
                case "N":
                    Y += 1;
                    break;
                case "S":
                    Y -= 1;
                    break;
            }
        }

        public void SetMovementDirections(List<string> movementDirections)
        {
            MovementDirections.AddRange(movementDirections);
        }
    }
}
