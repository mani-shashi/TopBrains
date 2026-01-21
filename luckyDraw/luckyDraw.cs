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

    public bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false; 
        }
        return true;
    }

    public bool IsLuckyNumber(int num)
    {
        if (IsPrime(num)) return false;
        
        int sumOfDigits = GetSumOfDigits(num);
        int squareOfSumOfDigits = sumOfDigits * sumOfDigits;
        int sumOfDigitsOfSquare = GetSumOfDigits(num * num);
        
        return (squareOfSumOfDigits == sumOfDigitsOfSquare);

    }
}