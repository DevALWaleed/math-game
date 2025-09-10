// TODO (Alwaleed): Record results in a list and make the user access his results history
// TODO (Alwaleed): Make the user access his results history
// TODO (Alwaleed): Display wrong message if result is wrong

int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next(0, 11); // Generating a random number from 0 to 10
}

int GetUserAnswer()
{
    return Convert.ToInt32(Console.ReadLine());
}

// Creating a main menu
var userMenuChoice = "";
while (userMenuChoice != "5")
{
    Console.WriteLine("Welcome to Math Game! Please select what operation do you want to be questioned with:\n");
    Console.WriteLine("Type 1 for adding\n");
    Console.WriteLine("Type 2 for subtracing\n");
    Console.WriteLine("Type 3 for multiplication\n");
    Console.WriteLine("Type 4 for divison\n");
    Console.WriteLine("Type 5 to exit\n");

    // Generating two random operands each iteration
    var firstRandomOperand = GetRandomNumber();
    var secondRandomOperand = GetRandomNumber();

    // Take an input from a user to choose on the menu
    Console.Write("Your input: ");
    userMenuChoice = Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            {
                Console.WriteLine($"{firstRandomOperand} + {secondRandomOperand} = ?");

                var userAnswer = GetUserAnswer();
                if (userAnswer == (firstRandomOperand + secondRandomOperand)) Console.WriteLine("Correct!\n");
                else Console.WriteLine($"Wrong! The answer is: {firstRandomOperand + secondRandomOperand}");

                break;
            }

        case "2":
            {
                // Handling if result is negative number
                if (firstRandomOperand < secondRandomOperand) (firstRandomOperand, secondRandomOperand) = (secondRandomOperand, firstRandomOperand);

                Console.WriteLine($"{firstRandomOperand} - {secondRandomOperand} = ?");

                var userAnswer = GetUserAnswer();
                if (userAnswer == (firstRandomOperand - secondRandomOperand)) Console.WriteLine("Correct!\n");
                else Console.WriteLine($"Wrong! The answer is: {firstRandomOperand - secondRandomOperand}");

                break;
            }

        case "3":
            {
                
                Console.WriteLine($"{firstRandomOperand} * {secondRandomOperand} = ?");

                var userAnswer = GetUserAnswer();
                if (userAnswer == (firstRandomOperand * secondRandomOperand)) Console.WriteLine("Correct!\n");
                else Console.WriteLine($"Wrong! The answer is: {firstRandomOperand * secondRandomOperand}");

                break;
            }

        case "4":
            {
                // Handling if second operand do not equal to zero and bind it to 1
                if (secondRandomOperand == 0) secondRandomOperand = 1;

                // Handling if the result is not an integer
                if (firstRandomOperand % secondRandomOperand != 0)
                {
                    Random random = new Random();

                    secondRandomOperand = random.Next(1, 11); // between 1 and 10

                    var multiplier = random.Next(1, 11);

                    firstRandomOperand = secondRandomOperand * multiplier;

                    Console.WriteLine($"{firstRandomOperand} ÷ {secondRandomOperand} = ?");
                    var userAnswer = GetUserAnswer();
                    if (userAnswer == (firstRandomOperand / secondRandomOperand)) Console.WriteLine("Correct!\n");

                    break;
                }
                else
                {
                    Console.WriteLine($"{firstRandomOperand} / {secondRandomOperand} = ?");
                    var userAnswer = GetUserAnswer();
                    if (userAnswer == (firstRandomOperand / secondRandomOperand)) Console.WriteLine("Correct!\n");

                    break;
                }
            }

        case "5":
            Console.WriteLine("See you next time!");
            break;
    }

}