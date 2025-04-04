```mermaid
classDiagram
    class Color {
        -const int MinColorValue
        -const int MaxColorValue
        -readonly int red
        -readonly int green
        -readonly int blue
        -readonly int alpha
        +Color(int red, int green, int blue, int alpha)
        +Color(int red, int green, int blue, MaxColorValue)
        -int CheckColor(int value)
        +int GetRed()
        +int GetGreen()
        +int GetBlue()
        +int GetAlpha()
        +int GetGrey()
    }

    class Sphere {
        -Color color
        -float radius
        -int timesThrown
        +Sphere(Color color, float radius)
        +void Pop()
        +void Throw()
        +int GetTimesThrown()
        +void PrintState()
    }

    class Program {
        +static void Main()
    }

    Color <-- Sphere : uses
    
    Sphere <-- Program : uses
```