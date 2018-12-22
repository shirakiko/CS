using System; 
namespace Helloworld
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double a,b;
            double d = 0;
            Console.WriteLine("Please enter a number 'a'.");       
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a  number 'b'. ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a signal.");
            string c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    d = a + b;
                    break;

                case "-":
                    d = a - b;
                    break;


                case "*":
                    d = a * b;
                    break;
                case "/":
                    d = a / b;
                    break;

                default:
                    break;
            }
                  Console.WriteLine(d);     
        }
    }
}
