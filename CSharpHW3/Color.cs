using System;
namespace ColorAndBall
{
	public class Color
	{
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public int alpha { get; set; }

        public Color(int red, int green, int blue, int transp)
        {
            R = red;
            G = green;
            B = blue;
            alpha = transp;
        }

        public Color(int red, int green, int blue)
        {
            R = red;
            G = green;
            B = blue;
            alpha = 255;
        }

        public int GreyscaleValue()
        {
            return (R + G + B) / 3;
        }
	}
}

