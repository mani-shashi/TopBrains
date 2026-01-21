public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("LuCkY dRaW\n Enter number: ");

        // string input = Console.ReadLine();
        // int.TryParse (input, out int num);
        // LuckyDraw ld = new LuckyDraw();
        // Console.WriteLine($" {num} isLucky?  :  {ld.IsLuckyNumber(num)}\n" );

        
        
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