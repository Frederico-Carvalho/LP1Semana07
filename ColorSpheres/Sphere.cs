using System;

namespace ColorSpheres
{
    class Sphere
    {
        private readonly Color color;
        private float radius;
        private int timesThrown;

        public Sphere(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown() {
            return timesThrown;
        }

        public void PrintState()
        {
            Console.WriteLine($"Color: [R={color.GetRed()}, G={color.GetGreen()}, B={color.GetBlue()}, A={color.GetAlpha()}]");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Times Thrown: {timesThrown}");
            Console.WriteLine($"Grey: {color.GetGrey()}");
        }
    }
}