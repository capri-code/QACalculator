namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to the Calculator Application!");
            Console.WriteLine("Available operations: Add, Subtract, Multiply, Divide");

            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the operation (Add, Subtract, Multiply, Divide): ");
                string operation = Console.ReadLine()?.ToLower();

                double result = 0;

                switch (operation)
                {
                    case "add":
                        result = calculator.Add(num1, num2);
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;

                    case "subtract":
                        result = calculator.Subtract(num1, num2);
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;

                    case "multiply":
                        result = calculator.Multiply(num1, num2);
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;

                    case "divide":
                        result = calculator.Divide(num1, num2);
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        break;

                    default:
                        Console.WriteLine("Invalid operation entered. Please choose Add, Subtract, Multiply, or Divide.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
