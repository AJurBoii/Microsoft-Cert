// Step 1: Integrating If-Else with Loops
// Create a program that repeatedly asks the user to input a number between 1 and 10 and ensures the number is even. The loop should continue until the user enters a valid input using an if-else statement to check the validity.

// Instructions:

// Use a do-while loop to continuously prompt the user for an even number between 1 and 10.
// Inside the loop, use an if-else statement to validate whether the number is even and between 1 and 10.
// If the input is valid, print the number and exit the loop using the break statement. If it’s invalid, display an error message and repeat the prompt.

do {
    Console.WriteLine("Enter an even number between 1 and 10 (inclusive):");
    int num = int.Parse(Console.ReadLine());
    if (num >= 1 && num <= 10 && num % 2 == 0) {
        Console.WriteLine(num);
        break;
    } else {
        Console.WriteLine("Number is invalid. Please try again.");
    }
} while (true);

// Step 2: Using If-Else to Evaluate Grades
// Write a program that uses a for loop and an if-else structure to evaluate a list of student grades. For each grade, determine whether the student has passed or failed based on the grade value.

// Instructions:

// Define an array named grades containing a list of student grades.
// Use a for loop to iterate over each grade in the array.
// Inside the loop, use an if-else statement to check if each grade is greater than or equal to 65 (passing). Print "Pass" if the grade is passing and "Fail" if it is not.
int[] grades = {77, 24, 55, 66, 65, 90, 87};

for (int i = 0; i < grades.Length; i++) {
    if (grades[i] >= 65) {
        Console.WriteLine("Pass");
    } else {
        Console.WriteLine("Fail");
    }
}

// Step 3: Integrating Switch Statements with Loops
// Create a program that processes multiple orders by their status. Each order can be "Pending," "Shipped," "Delivered," or "Cancelled," and the program will print a message based on the status of each order.

// Instructions:

// Define an array named orderStatuses containing different statuses: "Pending," "Shipped," "Delivered," and "Cancelled."
// Use a loop to iterate through the list of order statuses.
// Inside the loop, use a switch statement to print a different message based on the order’s status.
string[] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled", "Bababooey"};

for (int i = 0; i < orderStatuses.Length; i++) {
    switch ( orderStatuses[i]) {
        case "Pending":
            Console.WriteLine("Order is pending.");
            break;
        case "Shipped":
            Console.WriteLine("Order has shipped.");
            break;
        case "Delivered":
            Console.WriteLine("Order has been delivered.");
            break;
        case "Cancelled":
            Console.WriteLine("Order has been cancelled.");
            break;
        default:
            Console.WriteLine("Unknown order status.");
            break;
    }
}

// Step 4: Evaluating Student Grades with Switch and Loops
// Write a program that uses a for loop to iterate over a list of student scores and a switch statement to assign letter grades based on the score.

// Instructions:

// Define an array of student scores.
// Use a for loop to iterate through each score.
// Inside the loop, use a switch statement to assign a letter grade (A, B, C, D, F) based on the score.
int[] studentScores = {94, 23, 65, 77, 85, 59};

for (int i = 0; i < studentScores.Length; i++) {
    int score = studentScores[i];
    string grade;
    switch (score) {
        case int n when (n >= 90):
            grade = "A";
            break;
        case int n when (n >= 80):
            grade = "B";
            break;
        case int n when (n >= 70):
            grade = "C";
            break;
        case int n when (n >= 60):
            grade = "D";
            break;
        default:
            grade = "F";
            break;
    }
    Console.WriteLine($"Score: {score}. Grade: {grade}");
}