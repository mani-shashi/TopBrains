public class LargestInteger
{
    public int GetLargestInteger(int first, int second, int third)
    {
        int largest;

        if (first >= second && first >= third)
        {
            largest = first;
        } else if (second >= first && second >= third)
        {
            largest = second;
        }
        else
        {
            largest = third;
        }

        return largest;
    }
}