// Step 1: Using a For Loop to Calculate Total Scores
// You are developing a program for a quiz system to calculate the total score of a student based on individual quiz scores. The scores are stored in an array, and you need to use a for loop to sum them up.

// Instructions:

// Define an array named scores containing the integers 85, 90, 78, 92, and 88.

// Use a for loop to iterate over each element in the array and calculate the total score.

// Print the total score using Console.WriteLine().

int[] scores = {85, 90, 78, 92, 88};

int totalScore(int[] scores) {
    int sum = 0;
    for (int i = 0; i < scores.Length; i++) {
        sum += scores[i];
    }
    Console.WriteLine("Total score: " + sum);
    return sum;
}

totalScore(scores);

// Step 2: Using a While Loop to Calculate Factorials
// Create a program that calculates the factorial of a given number using a while loop. The program should ask the user for an integer and then calculate its factorial.

// Instructions:

// Declare an integer variable number and set its value to 5.

// Use a while loop to calculate the factorial of the number.

// After each iteration, decrement the value of number.

// Print the factorial using Console.WriteLine().
int number = 5;

int factorial(int number) {
    int total = 1;
    while (number > 0) {
        total = total * number;
        number--;
    }
    return total;
}

Console.WriteLine(number + "! = " + factorial(number));


// Step 3: Combining Loops and If-Else to Determine Pass or Fail
// Write a program that uses a for loop with an if-else structure to check if each student's score meets the passing criteria. A student passes if their score is 50 or above.

// Instructions:

// Define an array named studentScores containing the integers 45, 60, 72, 38, and 55.

// Use a for loop to iterate over each element in the array.

// Inside the loop, use an if-else statement to check if the score is 50 or above.

// Print "Pass" if the score is 50 or above; otherwise, print "Fail."
int[] studentScores = {45, 60, 72, 38, 55};

void passFail(int[] scores) {
    for (int i = 0; i < scores.Length; i++) {
        if (scores[i] >= 50) {
            Console.WriteLine("Pass");
        } else {
            Console.WriteLine("Fail");
        }
    }
}

passFail(studentScores);

// Step 4: Combining Loops and Switch Statements for Task Scheduling
// Create a program that schedules weekly tasks using a switch statement inside a for loop to assign a task for each day.

// Instructions:

// Define an array named weekDays containing the strings "Monday," "Tuesday," "Wednesday," "Thursday," "Friday."

// Use a for loop to iterate over each element in the array.

// Inside the loop, use a switch statement to assign a task to each day:

// If it's "Monday," print "Team Meeting."
// If it's "Tuesday," print "Code Review."
// If it's "Wednesday," print "Development."
// If it's "Thursday," print "Testing."
// If it's "Friday," print "Deployment."
string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};

void assignTasks(string[] weekDays) {
    for (int i = 0; i < weekDays.Length; i++) {
        switch (weekDays[i]) {
            case "Monday":
                Console.WriteLine("Team Meeting.");
                break;
            case "Tuesday":
                Console.WriteLine("Code Review.");
                break;
            case "Wednesday":
                Console.WriteLine("Development.");
                break;
            case "Thursday":
                Console.WriteLine("Testing.");
                break;
            case "Friday":
                Console.WriteLine("Deployment.");
                break;
            default:
                Console.WriteLine("Invalid weekday");
                break;
        }
    }
}

assignTasks(weekDays);