using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Xml.Linq;


using System;

// Create a class named MyClass
class MyClass
{
    // Define a void method that takes two integers as parameters
    public void MathOperation(int firstNumber, int secondNumber)
    {
        // Perform a math operation on the first integer
        int result = firstNumber * 2;

        // Display the second integer to the screen
        Console.WriteLine("Second Number: " + secondNumber);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate the MyClass object
        MyClass myObject = new MyClass();

        // Call the MathOperation method, passing in two numbers
        myObject.MathOperation(3, 5);

        // Call the MathOperation method, specifying the parameters by name
        myObject.MathOperation(firstNumber: 7, secondNumber: 9);
    }
}




