public class Program {

    // Step 1: Defining and Calling a Simple Method
    // Create a method that performs a task and call it in a program. This method should print a welcome message to the console.

    // Instructions:
    // Define a method named DisplayWelcomeMessage that prints "Welcome to our Program!" to the console.
    // Call the method to display the message.
    public static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to our Program!");
    }

    // Step 2: Creating a Method with Parameters
    // Create a method that accepts a parameter to make the method more flexible and reusable. This method should greet a user with a personalized message.

    // Instructions:
    // Define a method GreetUser that accepts a string parameter called name and prints a personalized message like "Hello [name]!".
    // Call this method and pass a name as an argument.
    public static void GreetUser(string name) {
        Console.WriteLine("Hello " + name + "!");
    }

    // Step 3: Using Methods with Return Values
    // Create a method that returns a value. This method should calculate the sum of two numbers and return the result.

    // Instructions:
    // Define a method CalculateSum that takes two integer parameters and returns their sum.
    // Call the method passing two numbers and print the result.
    public static int CalculateSum(int a, int b) {
        return a + b;
    }

    // Step 4: Combining Methods and Conditional Logic
    // Create a method that returns a bool value based on a condition. This method should check if a number is positive.

    // Instructions:
    // Define a method IsPositive that takes an integer as a parameter and returns a bool indicating whether the number is positive.
    // Call the method and print whether the number is positive or not.
    public static bool IsPositive(int num) {
        if (num > 0) {
            return true;
        }
        return false;
    }

    // Step 5: Practical Application – User Age Validation
    // Create a program to validate user input using methods. This program should ask for the user’s age and check if they are old enough to drive.

    // Instructions:
    // Define a method IsOldEnoughToDrive that takes an integer (age) and returns a bool indicating whether the person is old enough to drive.
    // Call the method after asking for the user’s age and display an appropriate message.
    public static bool IsOldEnoughToDrive(int age) {
        if (age >= 18) {
            Console.WriteLine("You are old enough to drive.");
            return true;
        }
        Console.WriteLine("You are not old enough to drive.");
        return false;
    }
}

Program.DisplayWelcomeMessage();
Program.GreetUser("AJ");
Console.WriteLine(Program.CalculateSum(6, 9));
Console.WriteLine(Program.IsPositive(-5));
Program.IsOldEnoughToDrive(16);