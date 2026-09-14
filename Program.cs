namespace TerminalCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 3 || parts.Length % 2 == 0)
                {
                    Console.WriteLine("Error");
                    continue;
                }
                double result = Convert.ToDouble(parts[0]);
                for (int i = 1; i < parts.Length; i += 2)
                {
                    string operation = parts[i];
                    double number = Convert.ToDouble(parts[i + 1]);

                    switch (operation)
                    {
                        case "+":
                            result += number;
                            break;
                        case "-":
                            result -= number;
                            break;

                        case "*":
                            result *= number;
                            break;
                        case "/":
                            if (number == 0)
                            {
                                Console.WriteLine("Cannot divide by zero.");
                                continue;
                            }

                            result /= number;
                            break;

                        default:
                            Console.WriteLine("Unknown operation.");
                            break;
                    }
                }

                Console.WriteLine($"= {result}");
            }
        }
    }
}
