
namespace CalculatorConsoleApp
{
    class CalculatorConsoleApp{
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result = 0;
            char operation;
            Boolean IO = true;
            
            
            
            Console.WriteLine("Hello, This is the Console Calculator!");
            Console.WriteLine("Please enter the first number: ");

            num1 = Convert.ToInt32(Console.ReadLine()); //Casts 1st input (String) to Int
            
            Console.WriteLine("Please enter the second number: ");
            
            num2 = Convert.ToInt32(Console.ReadLine()); //Casts 2nd input (String) to Int

            Console.WriteLine("What operation would you like to perform? ");
            Console.WriteLine("Please enter the operation symbol: ");

            operation = Convert.ToChar(Console.ReadLine());

            while(IO == true)
            {
                if (operation == '+')
                {
                    result = num1 + num2;
                    IO = false;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    IO = false;
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    IO = false;
                }
                else if (operation == '/')
                {
                    result = num1 / num2;
                    IO = false;
                }
                else
                {
                    IO = true;
                }    
            }

            Console.WriteLine("The result: " + result);
            
            Console.ReadKey(); //Press any key to close
        }
        
    }
    
}
