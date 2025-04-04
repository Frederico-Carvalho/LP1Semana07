using System;

namespace ColorSpheres
{
    class Color
    {
        private const int MinColorValue = 0;
        private const int MaxColorValue = 255;
        private readonly int red;
        private readonly int green;
        private readonly int blue;
        private readonly int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = CheckColors(red);
            this.green = CheckColors(green);
            this.blue = CheckColors(blue);
            this.alpha = CheckColors(alpha);
        }

        public Color(int red, int green, int blue) : this(red, green, blue, MaxColorValue) { }
        private int CheckColors(int value)
        {
            return Math.Clamp(value, MinColorValue, MaxColorValue);
        }

        public int GetRed() => red;
        public int GetGreen() => green;
        public int GetBlue() => blue;
        public int GetAlpha() => alpha;

        public int GetGrey() { 
            return (red + green + blue) / 3; 
        }
    }
}