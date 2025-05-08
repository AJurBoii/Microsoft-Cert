public class Program {
    // Step 1: Defining and Calling a Simple Method
    // Create a method that prints a welcome message to the console. This method demonstrates the basic structure and use of a method in C#.

    // Instructions:
    // Define a method called DisplayWelcomeMessage that prints "Welcome to the Program!" when called.
    // Call the method from the Main method to execute it.
    public static void DisplayWelcomeMessage() {
        Console.WriteLine("Welcome to the Program!");
    }

    // Step 2: Creating a Method with Parameters
    // Create a method that takes a parameter to provide personalized output. This method should greet a user by name.

    // Instructions:
    // Define a method called GreetUser that takes a string parameter name and prints "Hello [name]!".
    // Call the method from the Main method, passing a name as an argument.
    public static void GreetUser(string name) {
        Console.WriteLine("Hello " + name + "!");
    }

    // Step 3: Using Methods with Return Values
    // Create a method that returns a value. This method should add two numbers together and return the sum.

    // Instructions:
    // Define a method called CalculateSum that takes two integer parameters and returns their sum.
    // Store the result of the method call in a variable and print it.
    public static int CalculateSum(int a, int b) {
        return a + b;
    }

    // Step 4: Combining Methods and Conditional Logic
    // Create a method that returns a boolean value based on a condition. This method should check if a number is positive.

    // Instructions:
    // Define a method called IsPositive that takes an integer parameter and returns true if the number is greater than zero or false if not.
    // Use an if-else statement in the Main method to check the result and print whether the number is positive.
    public static bool IsPositive(int num) {
        return num > 0;
    }

    // Step 5: Practical Application – User Age Validation
    // Create a program to validate user input using methods. This program should ask for the user’s age and check if they are old enough to drive.

    // Instructions:
    // Define a method called IsOldEnoughToDrive that takes an integer parameter age and returns true if the age is 18 or older.
    // In the Main method, prompt the user to enter their age.
    // Convert the user's input to an integer using int.Parse().
    // Call the method and print whether the user is old enough to drive based on the return value of the method.
    public static bool IsOldEnoughToDrive(int age) {
        return age >= 18;
    }
}

Program.DisplayWelcomeMessage();

Program.GreetUser("AJ");

int sum = Program.CalculateSum(5, 10);
Console.WriteLine(sum);

Console.WriteLine(Program.IsPositive(-8));

Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());
if (Program.IsOldEnoughToDrive(age)) {
    Console.WriteLine("You are old enough to drive.");
} else {
    Console.WriteLine("You are not old enough to drive.");
}