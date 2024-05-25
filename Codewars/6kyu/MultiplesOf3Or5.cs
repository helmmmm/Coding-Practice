public static class MultiplesOf3Or5
{
    public static int Solution(int value)
    {
        if (value < 0)
            return 0;

        var multiples = new HashSet<int>();
        int sum = 0;

        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                if (!multiples.Contains(i))
                {
                    multiples.Add(i);
                    sum += i;
                }
            }
        }

        return sum;
    }
}