
public class Program {
    // Problem 1: Creating a Function for Circle Area Calculation
    // Problem Statement

    // Write a method to calculate the area of a circle. The method should accept one input parameter: the radius of the circle. The program should prompt the user for this value, use the method to compute the area, and then display the result.

    // Formula: The area of a circle is given by π * r^2 where r is the radius of the circle.
    public static decimal calculateCircleArea(decimal radius) {
        return (decimal)Math.PI * radius * radius;
    }

    // Problem 2: Creating a Function for Trapezoid Area Calculation
    // Problem Statement

    // Write a method to calculate the area of a trapezoid. The method should accept three input parameters: the length of the two parallel sides (a and b) and the height. The program should prompt the user for these values, use the method to compute the area, and then display the result.

    // Formula: The area of a trapezoid is given by (a + b) / 2 * height.
    public static decimal calculateTrapezoidArea(decimal a, decimal b, decimal height) {
        return (a + b) / 2 * height;
    }
}

Console.WriteLine("Enter circle radius:");
decimal radius = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Circle area is " + Program.calculateCircleArea(radius));

Console.WriteLine("Enter parallel side 'a':");
decimal a = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter parallel side 'b':");
decimal b = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter trapezoid height:");
decimal height = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Trapezoid area is " + Program.calculateTrapezoidArea(a, b, height));