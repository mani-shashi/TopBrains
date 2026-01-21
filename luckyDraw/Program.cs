public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nLuCkY dRaW\n ");
        
        Console.Write("Enter start: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter end: ");
        int end = int.Parse(Console.ReadLine());
        LuckyDraw ld = new LuckyDraw();

        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($" {i} isLucky?  :  {ld.IsLuckyNumber(i)}\n");
            
        }


    }
}