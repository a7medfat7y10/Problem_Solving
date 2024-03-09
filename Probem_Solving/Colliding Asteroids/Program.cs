namespace Colliding_Asteroids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in CollidingAsteroids(new int[] {-3,5,6,7,-4,-7}))
            {
                Console.WriteLine(i);
            }
        }
        //O(n) time / O(n) space
        public static int[] CollidingAsteroids(int[] asteroids)
        {
            // Write your code here.
            Stack<int> stack = new Stack<int>();
            foreach (var asteroid in asteroids)
            {
                if (stack.Count == 0 || asteroid > 0 || stack.Peek() < 0)
                {
                    stack.Push(asteroid);
                    continue;
                }

                while (stack.Count > 0)
                {
                    if (stack.Peek() < 0)
                    {
                        stack.Push(asteroid);
                        break;
                    }
                    if (stack.Peek() > Math.Abs(asteroid))
                        break;
                    if (stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                        break;
                    }
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        stack.Push(asteroid);
                        break;
                    }
                }
            }
            int[] result = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }
            return result;
        }
    }
}