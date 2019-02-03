using System;
using System.Threading;

namespace DesignPatterns.Patterns.Factory_Method
{
    public class ConcreteCreator : ICreator
    {
        private Random _random;
        private Timer _timer;
        private readonly int _level;

        public ConcreteCreator(int level)
        {
            _random = new Random();
            _timer = new Timer(new TimerCallback(TimerTask), null, 1000, 20000);
            _level = level;
        }

        public Obstacle CreateObstacle(int level)
        {
            // higher level is more chance
            // get random value between 1 - 100

            var randomValue = _random.Next(1, 100);
            var threshold = (level / 10);
            var size = level * randomValue;
            var velocity = level;

            if (randomValue < threshold)
            {
                return new Asteroid(size, velocity);
            }
            else if (randomValue < threshold * level)
            {
                return new Shipwreck(size, velocity);
            }

            return null;
        }

        private void TimerTask(object timerState)
        {
            var product = CreateObstacle(_level);
        }
    }
}