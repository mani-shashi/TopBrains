public class LuckyDraw
{


    public int GetSumOfDigits(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            int last = num % 10;
            sum += last;
            num /= 10;
        }
        return sum;
    }

    public bool IsLuckyNumber(int num)
    {
        
        int sumOfDigits = GetSumOfDigits(num);
        int squareOfSumOfDigits = sumOfDigits * sumOfDigits;
        int sumOfDigitsOfSquare = GetSumOfDigits(num * num);



        // string numAsString = string.parse(num);

        // int length = numAsString.Length;
        // int first = numAsString[0];
        // int last = numAsString[length - 1];

        
        return (squareOfSumOfDigits == sumOfDigitsOfSquare);

    }
}