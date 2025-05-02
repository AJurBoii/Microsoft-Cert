// Problem 1
// You are developing a program to calculate the membership fee for a gym. The fee depends on the user’s age and membership type:

// For users under 18, the fee is $15 for a basic membership and $25 for a premium membership.

// For users between 18 and 60, the fee is $30 for a basic membership and $50 for a premium membership.

// For users over 60, the fee is $20 for a basic membership and $35 for a premium membership.

void membershipFee() {
    int age;
    string type;

    Console.WriteLine("Enter your age:");
    age = int.Parse(Console.ReadLine());
    Console.WriteLine("Choose a membership type: basic or premium");
    type = Console.ReadLine().ToLower();

    if (age < 18) {
        if (type == "basic") {
            Console.WriteLine("Basic membership fee is $15.");
        } else {
            Console.WriteLine("Premium membership fee is $25.");
        }
    } else if (age >= 18 && age <= 60) {
        if (type == "basic") {
            Console.WriteLine("Basic membership fee is $30.");
        } else {
            Console.WriteLine("Premium membership fee is $50.");
        }
    } else {
        if (type == "basic") {
            Console.WriteLine("Basic membership fee is $20.");
        } else {
            Console.WriteLine("Premium membership fee is $35.");
        }
    }
}

membershipFee();

// Problem 2
// You are developing a bank account management system. The program must manage different types of bank accounts and apply the correct fees or interest rates based on the account type:

// Savings Account: Apply a 2% interest rate.

// Checking Account: Apply a $10 monthly fee.

// Business Account: Apply a 1% interest rate and a $20 monthly fee.

// For all other account types, display an error message.

// Instructions:

// Write a switch case to handle different account types and apply the correct fees or interest rates.
void bankAccountManagement() {
    string accountType;
    Console.WriteLine("Enter account type: Savings, Checking, or Business");
    accountType = Console.ReadLine().ToLower();

    switch (accountType) {
        case "savings":
            Console.WriteLine("2% interest applied.");
            break;
        case "checking":
            Console.WriteLine("$10 monthly fee applied.");
            break;
        case "business":
            Console.WriteLine("1% interest and $20 monthly fee applied.");
            break;
        default:
            Console.WriteLine("Error: Invalid account type.");
            bankAccountManagement();
            break;
    }
}

bankAccountManagement();