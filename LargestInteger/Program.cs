public class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter First Number: ");
        int.TryParse(Console.ReadLine(), out int first);
        Console.Write("Enter Second Number: ");
        int.TryParse(Console.ReadLine(), out int second);
        Console.Write("Enter Third Number: ");
        int.TryParse(Console.ReadLine(), out int third);

        LargestInteger li = new LargestInteger();
        int largest = li.GetLargestInteger(first,second,third);
        Console.WriteLine($"Largest Integer[{first},{second},{third}]: " + largest);
    }
}