using System;

namespace DesignPatterns.Patterns.Factory_Method
{
    public interface ICreator
    {
        Obstacle CreateObstacle(int level);
    }
}