// See https://aka.ms/new-console-template for more information

//Random random = new Random();

//int randomNumber = random.Next(1, 11);

//int counter = 0;

//while (true)
//{
//    counter++;
//    int guess = 0;
//    Console.WriteLine("Guess a number under 10:");
//    if (int.TryParse(Console.ReadLine(), out guess))
//    {
//        if (guess == randomNumber)
//        {
//            Console.WriteLine($"You guess correctly in {counter} tries!");
//            break;
//        }
//        else if (guess > randomNumber)
//        {
//            Console.WriteLine("Your guess is too large.");
//        }
//        else
//        {
//            Console.WriteLine("Your guess is too small.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Please type a number.");
//    }
//}

//Console.ReadKey();


Console.WriteLine("Enter the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Choose an operation: +, -, *, /");

string op = Console.ReadLine();
int result = 0;
if (op == "+")
{
    result = firstNumber + secondNumber;
}
else if (op == "-")
{
    result = firstNumber - secondNumber;
}
else if (op == "*")
{
    result = firstNumber * secondNumber;
}
else if (op == "/")
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
        return;
    }
    else
    {
        result = firstNumber / secondNumber;
    }
}
else
{
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
    return;
}

Console.WriteLine($"Result: {result}");