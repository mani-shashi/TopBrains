using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter number to print multiplication table: ");
        int.TryParse(Console.ReadLine(), out int num);
        Console.Write("Enter upto: ");
        int.TryParse(Console.ReadLine(), out int upto);

        //constraints
        if (num < 0 || num > 1e4 ) return;
        if (upto < 0 || upto > 1e5 ) return;

        MultiplicationTable mt = new MultiplicationTable();
        int[] table = mt.GetCustomMultiplicationTable(num,upto);

        string result = String.Join(",",table); //joining array with comma for better printing

        Console.WriteLine($"Multiplication table of {num} upto {upto} : [{result}] ");
    }
}