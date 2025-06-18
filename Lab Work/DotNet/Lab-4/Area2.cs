/*5. Write a programs to Find Area of Square, Rectangle and Circle using 
Method Overloading. */

class Area2
{
    public void arrea(int a)
    {
        Console.WriteLine("Area of square: " + (a * a));
    }
    public void arrea(int a, int b)
    {
        Console.WriteLine("Area of rectangle: " + (a * b));
    }

    public void arrea(double r)
    {
        Console.WriteLine("Area of circle: " + (3.14 * r * r));
    }
}