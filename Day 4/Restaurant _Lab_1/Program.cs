namespace Restaurant__Lab_1;
//Write a Restaurant C# program that asks a user "Which protein would you like?" and depending on their answer, respond with the available menu item. (eg. beef -> hamburger, pepperoni -> pizza, tofu -> tofu fried rice, etc).   
 
// If they ask for an unrecognized protein, respond with a message that that protein is not available. Write this program using the switch statement.
 
// Objective:
// Write a program using switch statement
class Program
{
    static void Main(string[] args)
    {
        //Initialization
        Console.WriteLine("Hello, What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nWelcome to our restaurant, {userName}!");
        Console.WriteLine("Which protein would you like?");
        string userProtein = Console.ReadLine().ToLower();
        switch (userProtein)
        {
            case "beef":
                Console.WriteLine("Here is your hamburger!");
                break;
            case "pepperoni":
                Console.WriteLine("Here is your pizza!");
                break;
            case "tofu":
                Console.WriteLine("Here is your tofu fried rice!");
                break;
            default:
                Console.WriteLine("Sorry, that protein is not available.");
                break;
        }
        Console.WriteLine("Thank you for visiting our restaurant!");
        Console.ReadLine();
        //End of program.
        
        
    }
}
