using System.Collections.Generic;

namespace RobotApplication.Entities.Abstract
{
    public interface IRobot
    {
        void SetMovementDirections(List<string> movementDirections);
        void MoveTheRobot();
    }
}
