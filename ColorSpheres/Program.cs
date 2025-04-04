﻿using System;

namespace ColorSpheres
{
    public class Color
    {
        private const int MinColorValue = 0;
        private const int MaxColorValue = 255;
        private readonly int red;
        private readonly int green;
        private readonly int blue;
        private readonly int alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            this.red = ValidateColorComponent(red);
            this.green = ValidateColorComponent(green);
            this.blue = ValidateColorComponent(blue);
            this.alpha = ValidateColorComponent(alpha);
        }

        public Color(int red, int green, int blue) : this(red, green, blue, MaxColorValue) { }

        private int ValidateColorComponent(int value)
        {
            return Math.Clamp(value, MinColorValue, MaxColorValue);
        }

        public int GetRed() => red;
        public int GetGreen() => green;
        public int GetBlue() => blue;
        public int GetAlpha() => alpha;

        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }
    }
    public class Sphere
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

        public int GetTimesThrown() => timesThrown;

        public void PrintState()
        {
            Console.WriteLine($"Color: [R={color.GetRed()}, G={color.GetGreen()}, B={color.GetBlue()}, A={color.GetAlpha()}]");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Times Thrown: {timesThrown}");
            Console.WriteLine($"Grey: {color.GetGrey()}");
        }
    }
    
}