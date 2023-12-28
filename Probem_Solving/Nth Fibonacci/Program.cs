namespace Nth_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNthFib(6));
        }
        public static int GetNthFib(int n)
        {
            // Write your code here.
            if (n == 2)
                return 1;
            if (n == 1)
                return 0;
            return GetNthFib(n - 1) + GetNthFib(n - 2);

        }
    }
}