using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color green = new Color(0,255,0);
            Sphere sphere1 = new Sphere(green, 20);
            Color red = new Color(255,0,0);
            Sphere sphere2 = new Sphere(red, 10);
            Color yellow = new Color(255,255,0);
            Sphere sphere3 = new Sphere(yellow, 30);
            sphere1.Throw();
            sphere2.Pop();
            sphere3.Pop();
            sphere3.Throw();

            sphere1.PrintState();
            sphere2.PrintState();
            sphere3.PrintState();
        }
    }
}