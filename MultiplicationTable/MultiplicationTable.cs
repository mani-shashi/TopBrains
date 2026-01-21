public class MultiplicationTable
{
     public int[] GetCustomMultiplicationTable(int num, int upto)
    {
        int[] multiplications = new int[upto];

        for (int i = 1; i <= upto; ++i)
        {
            multiplications[i - 1] = num * i;
        }

        return multiplications;
    }
}