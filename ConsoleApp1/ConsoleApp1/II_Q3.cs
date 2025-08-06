using System.Runtime.InteropServices;

class II_Q3
{
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        int[] primes = new int[0];

        for (int i = startNum; i <= endNum; i += 1)
        {
            bool flag = false;
            for (int j = 2; j < i; j += 1)
            {
                if (i % j == 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Array.Resize(ref primes, primes.Length + 1);
                primes[primes.Length - 1] = i;
                Console.WriteLine($"{i} is a prime number");
            }
        }
        return primes;
    }
}