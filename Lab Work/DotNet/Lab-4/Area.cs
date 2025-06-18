/*2. Write a program using method overloading by changing number of     
arguments to calculate area of square and rectangle. */

public class Area
{
    public void arrea(int a)
    {
        Console.WriteLine("Area of square: " + (a * a));
    }
    public void arrea(int a, int b)
    {
        Console.WriteLine("Area of rectangle: " + (a * b));
    }
}