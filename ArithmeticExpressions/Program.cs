using System.Data;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Expression: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(" ");

        string expression = inputArray[1];
        int first = int.Parse(inputArray[0]);
        int last = int.Parse(inputArray[2]);
        string result = "";

        if ( expression == "+")
        {
            result = first + last;
        } 
        else if (expression == "-")
        {
            result = first - last;
        } 
        else if (expression == "*")
        {
            result = first * last;
        } 
        else if (expression == "/")
        {
            if (last == 0) throw DivideByZeroException();
            result = first / last;
        }
        else
        {
            throw InvalidExpressionException();
        }
                
        



        
    }
}