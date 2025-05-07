// Problem 1: Creating a Function for Circle Area Calculation
// Problem Statement
// Write a function to calculate the area of a circle. The function should accept one input parameter: the radius of the circle. The program should prompt the user for this value, use the function to compute the area, and then display the result.

// Formula: The area of a circle is given by π * r^2 where r is the radius of the circle. For Pi you will use the code Math.PI.
double calculateCircleArea(double radius) {
    return Math.PI * (radius * radius);
}

Console.WriteLine("Enter circle radius:");
double radius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The area of the circle is " + calculateCircleArea(radius));

// Problem 2: Creating a Function for Trapezoid Area Calculation
// Problem Statement
// Write a function to calculate the area of a trapezoid. The function should accept three input parameters: the length of the two parallel sides (a and b) and the height. The program should prompt the user for these values, use the function to compute the area, and then display the result.

// Formula: The area of a trapezoid is given by (a + b) / 2 * height.
double calculateTrapezoidArea(double a, double b, double height) {
    return (a + b) / 2 * height;
}

Console.WriteLine("Enter parallel side 'a' length:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter parallel side 'b' length:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter trapezoid height:");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The area of the trapezoid is " + calculateTrapezoidArea(a, b, height));