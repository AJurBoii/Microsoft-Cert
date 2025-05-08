public class Program {
    // Problem 1: Calculate the Volume of a Rectangular Box
    // Problem Statement:
    // Write a method that calculates the volume of a rectangular box. The method should accept three integer parameters: length, width, and height. The method should return the volume calculated as:
    // Volume = length * width * height.
    public static int CalculateVolume(int length, int width, int height) {
        return length * width * height;
    }

    // Problem 2: Calculate the Average of Three Numbers
    // Problem Statement:
    // Write a method that calculates the average of three integer numbers. The method should accept three parameters: num1, num2, and num3. The method should return the average as an integer.
    public static int CalculateAverage(int num1, int num2, int num3) {
        return (int) (num1 + num2 + num3) / 3;
    }
}

Console.WriteLine("Enter box length:");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Enter box width:");
int width = int.Parse(Console.ReadLine());
Console.WriteLine("Enter box height:");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("Box volume is " + Program.CalculateVolume(length, width, height));

Console.WriteLine("Enter first number:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter third number:");
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine("The average is " + Program.CalculateAverage(num1, num2, num3));