public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double area = CalculateArea(radius);
        Console.Write($"Area : {area}");
    }

    public static double CalculateArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area,2);
    }
}