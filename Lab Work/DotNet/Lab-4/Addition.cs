/*1.Write a program using method overloading by changing datatype of    
arguments to perform addition of two integer numbers and two float     
numbers. */

using System;

public class Addition
{
    public void add(int a, int b)
    {
        Console.WriteLine("Addition of two integers: " + (a + b));      
    }
    public void add(float a, float b)
    {
        Console.WriteLine("Addition of two float numbers: " + (a + b));
    }
}