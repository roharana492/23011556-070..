using System;
using System.Linq;
public static class ConsoleUtility
{
    /// <param name="prompt">The text prompt to display to the user.</param>
    /// <param name="number">The parsed integer result.</param>
   
    public static bool TryReadInt(string prompt, out int number)
    {
        Console.Write(prompt);
        return int.TryParse(Console.ReadLine(), out number);
    }

    /// <param name="prompt">The text prompt to display to the user.</param>
    /// <param name="number">The parsed double result.</param>
   
    public static bool TryReadDouble(string prompt, out double number)
    {
        Console.Write(prompt);
        return double.TryParse(Console.ReadLine(), out number);
    }
}
public class Q1_NumberChecker
{
    public void CheckEvenOrOdd()
    {
        Console.WriteLine("\n--- [1] Even or Odd Checker (Conditionals) ---");

        if (ConsoleUtility.TryReadInt("Please enter a whole number: ", out int number))
        {
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"\nResult: The number {number} is EVEN.");
            }
            else
            {
                Console.WriteLine($"\nResult: The number {number} is ODD.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a valid whole number (e.g., 42 or -5).");
        }
        Console.WriteLine("--------------------------------------------\n");
    }
}

public class Q2a_ArrayAnalyzer
{
    public void AnalyzeArray()
    {
        Console.WriteLine("\n--- [2a] Array Summation and Average (Arrays & Loops) ---");

        int[] numbers = { 10, 25, 40, 5, 20 };
        Console.WriteLine($"Initialized Array: [{string.Join(", ", numbers)}]");

        int sum = 0;

       
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        int count = numbers.Length;
        
        double average = (double)sum / count;

        Console.WriteLine($"\nTotal Sum: {sum}");
        Console.WriteLine($"Array Count: {count}");
        Console.WriteLine($"Average Value: {average:F2}");

        Console.WriteLine("--------------------------------------------------\n");
    }
}

public class Q2b_SimpleCalculator
{
    public void RunCalculator()
    {
        Console.WriteLine("\n--- [2b] Simple Console Calculator (Switch-Case) ---");

        if (!ConsoleUtility.TryReadDouble("Enter first number: ", out double num1))
        {
            Console.WriteLine("Invalid input for the first number. Cannot proceed.");
            Console.WriteLine("--------------------------------------------------\n");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(op))
        {
            Console.WriteLine("Invalid operator input. Cannot proceed.");
            Console.WriteLine("--------------------------------------------------\n");
            return;
        }

        if (!ConsoleUtility.TryReadDouble("Enter second number: ", out double num2))
        {
            Console.WriteLine("Invalid input for the second number. Cannot proceed.");
            Console.WriteLine("--------------------------------------------------\n");
            return;
        }

        double result = 0.0;
        bool isValidOperation = true;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("\nError: Division by zero is not allowed.");
                    isValidOperation = false;
                }
                break;
            default:
                Console.WriteLine("\nError: Invalid operator entered. Please use +, -, *, or /.");
                isValidOperation = false;
                break;
        }

        if (isValidOperation)
        {
            Console.WriteLine($"\nResult: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("--------------------------------------------------\n");
    }
}

public class Q3_GradeEvaluator
{
    public void DetermineGrade()
    {
        Console.WriteLine("\n--- [3] Grade Evaluator (Conditionals) ---");

        if (ConsoleUtility.TryReadInt("Enter student marks (0-100): ", out int marks) && marks >= 0 && marks <= 100)
        {
            string grade;

            if (marks >= 85)
            {
                grade = "A+";
            }
            else if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 70)
            {
                grade = "B";
            }
            else if (marks >= 55)
            {
                grade = "C";
            }
            else if (marks >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"\nResult: Marks of {marks} corresponds to Grade: {grade}");
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a whole number between 0 and 100.");
        }
        Console.WriteLine("---------------------------------------\n");
    }
}


public class Q4_NaturalNumberSummer
{
    public void CalculateSum()
    {
        Console.WriteLine("\n--- [4] Sum of Natural Numbers (For Loop) ---");

        if (ConsoleUtility.TryReadInt("Enter a positive whole number (n) to calculate the sum from 1 to n: ", out int n) && n > 0)
        {
            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"\nCalculation: 1 + 2 + ... + {n}");
            Console.WriteLine($"Result: The total sum is {sum}");
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a positive whole number.");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}
public class Q5_MultiplicationTable
{
    public void GenerateTable()
    {
        Console.WriteLine("\n--- [5] Multiplication Table Generator (For Loop) ---");

        if (ConsoleUtility.TryReadInt("Enter the number for which you want the multiplication table: ", out int num))
        {
            Console.WriteLine($"\nMultiplication Table for {num} (up to 10):");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a valid whole number.");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}


public class Q6_FactorialCalculator
{
    public void CalculateFactorial()
    {
        Console.WriteLine("\n--- [6] Factorial Calculator (While Loop) ---");

        if (ConsoleUtility.TryReadInt("Enter a non-negative whole number (n) to calculate its factorial (n!): ", out int n) && n >= 0)
        {
            if (n == 0)
            {
                Console.WriteLine("\nResult: 0! is 1.");
            }
            else
            {
                long factorial = 1;
                int currentNumber = n;

                // Loop from n down to 1
                while (currentNumber > 0)
                {
                    factorial *= currentNumber;
                    currentNumber--;
                }

                Console.WriteLine($"\nCalculation: {n}! = {factorial}");
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a non-negative whole number (0 or greater).");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}

public class Q7_NumberReverser
{
    public void ReverseNumber()
    {
        Console.WriteLine("\n--- [7] Reverse a Number (While Loop) ---");

        if (ConsoleUtility.TryReadInt("Enter a whole number to reverse its digits (e.g., 123): ", out int number))
        {
            long originalNumber = number;
            long reversedNumber = 0;

            // Handle negative sign
            int sign = Math.Sign(number);
            number = Math.Abs(number);

          
            while (number > 0)
            {
                int remainder = number % 10; 
                reversedNumber = (reversedNumber * 10) + remainder; 
                number /= 10; 
            }

            long finalReversedNumber = reversedNumber * sign;

            Console.WriteLine($"\nResult: The reverse of {originalNumber} is {finalReversedNumber}.");
        }
        else
        {
            Console.WriteLine("\nError: Invalid input. Please enter a valid whole number.");
        }
        Console.WriteLine("-------------------------------------------\n");
    }
}

public class Q8_ArraySearcher
{
    private const int ArraySize = 5;

    public void PerformLinearSearch()
    {
        Console.WriteLine($"\n--- [8/10] Array Search: Find Element in Array ({ArraySize} Integers) ---");
        int[] numbers = new int[ArraySize];
        bool validInput = true;

       
        Console.WriteLine($"Please enter {ArraySize} whole numbers to populate the array:");
        for (int i = 0; i < ArraySize; i++)
        {
            if (!ConsoleUtility.TryReadInt($"Enter number {i + 1}/{ArraySize}: ", out numbers[i]))
            {
                Console.WriteLine("\nError: Invalid input. Please only enter whole numbers. Cannot proceed.");
                validInput = false;
                break;
            }
        }

        if (!validInput) return;

        Console.WriteLine($"\nArray created: [{string.Join(", ", numbers)}]");

        // Target Input
        if (!ConsoleUtility.TryReadInt("Enter the number you want to search for: ", out int target))
        {
            Console.WriteLine("\nError: Invalid input for search target.");
            Console.WriteLine("-------------------------------------------\n");
            return;
        }

        int foundIndex = -1;

       
        for (int i = 0; i < ArraySize; i++)
        {
            if (numbers[i] == target)
            {
                foundIndex = i;
                break;
            }
        }

        Console.WriteLine("\n--- Search Results ---");
        if (foundIndex != -1)
        {
            Console.WriteLine($"Result: The number {target} was found at index position {foundIndex}.");
        }
        else
        {
            Console.WriteLine($"Result: The number {target} was NOT found in the array.");
        }

        Console.WriteLine("-------------------------------------------\n");
    }
}
public class Q9_EvenOddCounter
{
    private const int ArraySize = 10;

    public void CountNumbers()
    {
        Console.WriteLine($"\n--- [9] Array: Count Even and Odd Numbers ({ArraySize} Integers) ---");
        int[] numbers = new int[ArraySize];
        int evenCount = 0;
        int oddCount = 0;
        bool validInput = true;

      
        Console.WriteLine($"Please enter {ArraySize} whole numbers to populate the array:");
        for (int i = 0; i < ArraySize; i++)
        {
            if (!ConsoleUtility.TryReadInt($"Enter number {i + 1}/{ArraySize}: ", out numbers[i]))
            {
                Console.WriteLine("\nError: Invalid input detected. Please only enter whole numbers. Cannot proceed.");
                validInput = false;
                break;
            }
        }

        if (validInput)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("\n--- Analysis Results ---");
            Console.WriteLine($"Total numbers entered: {ArraySize}");
            Console.WriteLine($"Even Count: {evenCount}");
            Console.WriteLine($"Odd Count: {oddCount}");
        }

        Console.WriteLine("-------------------------------------------\n");
    }
}


public class AssignmentRunner
{
    private Q1_NumberChecker checker = new Q1_NumberChecker();
    private Q2a_ArrayAnalyzer arrayAnalyzer = new Q2a_ArrayAnalyzer();
    private Q2b_SimpleCalculator calculator = new Q2b_SimpleCalculator();
    private Q3_GradeEvaluator evaluator = new Q3_GradeEvaluator();
    private Q4_NaturalNumberSummer summer = new Q4_NaturalNumberSummer();
    private Q5_MultiplicationTable tableGenerator = new Q5_MultiplicationTable();
    private Q6_FactorialCalculator factorialCalculator = new Q6_FactorialCalculator();
    private Q7_NumberReverser reverser = new Q7_NumberReverser();
    private Q8_ArraySearcher searcher = new Q8_ArraySearcher();
    private Q9_EvenOddCounter counter = new Q9_EvenOddCounter();

    
    private void DisplayMenu()
    {
        Console.Clear(); 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=================================================");
        Console.WriteLine(" C# CONSOLIDATED ASSIGNMENT RUNNER (10 Programs) ");
        Console.WriteLine("=================================================");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 1. Check Even or Odd (Conditionals)");
        Console.WriteLine(" 2. Array Sum & Average (For Loop)");
        Console.WriteLine(" 3. Simple Console Calculator (Switch-Case)");
        Console.WriteLine(" 4. Grade Evaluator (If-Else If)");
        Console.WriteLine(" 5. Sum of Natural Numbers (For Loop)");
        Console.WriteLine(" 6. Multiplication Table (For Loop)");
        Console.WriteLine(" 7. Factorial Calculator (While Loop)");
        Console.WriteLine(" 8. Reverse a Number (While Loop)");
        Console.WriteLine(" 9. Array Linear Search (For Loop)");
        Console.WriteLine(" 10. Array Even/Odd Counter (Foreach Loop)");
        Console.WriteLine("-------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 0. Exit Program");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("=================================================");
    }

    public void RunProgram()
    {
        bool isRunning = true;
        while (isRunning)
        {
            DisplayMenu();
            Console.Write("\nEnter your choice (0-10): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("\nInvalid input. Press any key to try again...");
                Console.ReadKey();
                continue;
            }

           
            Console.Clear(); 
            switch (choice)
            {
                case 1: checker.CheckEvenOrOdd(); break;
                case 2: arrayAnalyzer.AnalyzeArray(); break;
                case 3: calculator.RunCalculator(); break;
                case 4: evaluator.DetermineGrade(); break;
                case 5: summer.CalculateSum(); break;
                case 6: tableGenerator.GenerateTable(); break;
                case 7: factorialCalculator.CalculateFactorial(); break;
                case 8: reverser.ReverseNumber(); break;
                case 9: searcher.PerformLinearSearch(); break;
                case 10: counter.CountNumbers(); break;
                case 0:
                    isRunning = false;
                    Console.WriteLine("\nExiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a number from 0 to 10.");
                    break;
            }

            if (isRunning)
            {
                Console.WriteLine("=================================================");
                Console.Write("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AssignmentRunner runner = new AssignmentRunner();
        runner.RunProgram();
    }
}

