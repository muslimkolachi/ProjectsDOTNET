try
{
    Console.WriteLine("Enter the first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Select an operation (+, -, *, /):");
    char operation = Console.ReadKey().KeyChar;

    int result = 0;

    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        default:
            Console.WriteLine("Invalid operation selected.");
            break;
    }

    Console.WriteLine($"Result: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
