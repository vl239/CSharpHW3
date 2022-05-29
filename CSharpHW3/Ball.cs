using System;
namespace ColorAndBall
{
	public class Ball
	{
        public Ball(int size, Color color)
        {
            BallSize = size;
            BallColor = color;
            ThrowCount = 0;
        }

        public int BallSize { get; set; }
        public Color BallColor { get; set; }
        public int ThrowCount { get; set; }
        
        public void Pop()
        {
            BallSize = 0;
        }

        public void Throw()
        {
            if (BallSize != 0)
            {
                ThrowCount++;
            }
        }

        public int TimesThrown()
        {
            return ThrowCount;
        }
    }
}

