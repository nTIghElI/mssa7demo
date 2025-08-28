//Lab 2:
 
// In this exercise, you are required to write a C# program:
 
// Hint:
// Write a Restaurant C# program that asks a user "Which protein would you like?" and depending on their answer, respond with the available menu item. (eg. beef -> hamburger, pepperoni -> pizza, tofu -> tofu fried rice, etc).   
 
// If they ask for an unrecognized protein, respond with a message that that protein is not available. Write this program using the if..else statement.
 
// Objective:
// Write a program using the if..else statement

namespace Restaurant__Lab_2;

class Program
{
    static void Main(string[] args)
    {
        List<string> beefMenu = new List<string>() { "hamburger", "pizza", "steak" };
        List<string> chickenMenu = new List<string>() { "chicken", "salad", "soup" };
        List<string> fishMenu = new List<string>() { "salmon", "tuna", "trout" };
        List<string> veggieMenu = new List<string>() { "carrots", "peas", "broccoli", "tofu" };
        List<string> drinkMenu = new List<string>() { "coffee", "tea", "water" };
        List<string> dessertMenu = new List<string>() { "ice cream", "cake", "pie" };

        Console.WriteLine("Hello, welcome to our restaurant!\nWhat is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello {userName}, what would you like to order?");
        string userOrder = Console.ReadLine().ToLower();
        Console.WriteLine($"Thank you {userName}, your order is {userOrder}");
        Console.WriteLine("Would you like to order something else?");
        string userOrderYesNo = Console.ReadLine().ToLower();
        //While loop to ask for another order    
        while (userOrderYesNo.Contains("yes"))
        {
            Console.WriteLine("What else would you like to order?");
            userOrder += Console.ReadLine().ToLower();
            break;
        }

        //Break out while loop
        //Check if userOrder contains any List items
        if (beefMenu.Contains(userOrder))
        {
            Console.WriteLine($"{beefMenu} is available at the restaurant, what would you like to order?");
            userOrder = Console.ReadLine().ToLower();
            //while loop to ask for another order
            while (userOrder.Contains("yes"))
            {
                Console.WriteLine("What else would you like to order?");
                userOrder += Console.ReadLine().ToLower();
                break;


            }
        }

    }
}
