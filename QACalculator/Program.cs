class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Simple Calculator!");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        Console.Write("Enter your choice (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    validOperation = false;
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                validOperation = false;
                break;
        }

        if (validOperation)
        {
            Console.WriteLine($"The result is: {result}");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}