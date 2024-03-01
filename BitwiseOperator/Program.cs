using System.Globalization;

namespace BitwiseOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Building A simple calculator in c#");
            Console.WriteLine();

        input: while(true)
            {
                try
                {

                    calculator cal = new calculator();
                    Console.WriteLine("Enter the first Operand: ");
                    cal.OperandOne = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the second Operand: ");
                    cal.OperandTwo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the Operator:(+, -, /,&, =, !, %, |, >, <, ) ");
                    cal.Op = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    cal.MakeCalculation();

                    Console.WriteLine("The result is {0}", cal.Result);
                    Console.WriteLine("The boolean ressult is {0}", cal.BoolResult);

                    Console.WriteLine("Please Enter to continue or type 'exit' to quit.");
                    String userInput = Console.ReadLine().Trim();
                    if(userInput.Equals("exi", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Existing the program");
                        break;
                    }

                }catch (FormatException) {
                    Console.WriteLine("Invalid input. Please enter numeric operands.");
                    goto input;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    goto input;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    goto input;

                }
            }
            



        }
    }
}
