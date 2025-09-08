// Creating a main menu with infinite loop
var userInput = "";
while (userInput != "5")
{
    Console.WriteLine("Welcome to Math Game! Please select what operation you want to do from below:");
    Console.WriteLine("Type 1 on your keyboard to perfrom adding.");
    Console.WriteLine("Type 2 on your keyboard to perform subtracing");
    Console.WriteLine("Type 3 on your keyboard to perform multiplication");
    Console.WriteLine("Type 4 on your keyboard to perform divison");
    Console.WriteLine("Type 5 on your keyboard to leave.");

    userInput = Console.ReadLine(); // Take an input from a user to choose on the menu
    switch (userInput)
    {
        // TODO (Al-Waleed): add a case for each operation
        case "5":
            Console.WriteLine("See you next time!");
            break;
    }
    
}