using System;

namespace primenumbers
{
    class Program
    {
        public static bool isprime(int x)
        {
            int a = (int)Math.Floor(Math.Sqrt(x));
            if (x==1)
            {
                return false;
            }
             if (x ==1)
            {
                return true;
            }
             for (int i=2;i<=a;++i)
            {
                if(x % i ==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("first 500 prime numbers");
            int x = 2;
            int y = 0;
            long sum = 0;
            while(y<500)
            {
                if (isprime(x))
                {
                    sum += x;
                    y++;
                }
                x++;
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
