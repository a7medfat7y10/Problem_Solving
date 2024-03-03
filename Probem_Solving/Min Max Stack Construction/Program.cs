namespace Min_Max_Stack_Construction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min Max Stack Construction");
        }
        public class MinMaxStack
        {
            List<int> stack = new List<int>();
            List<Dictionary<string, int>> minMaxStack = new List<Dictionary<string, int>>();
            public int Peek()
            {
                // Write your code here.
                return stack[stack.Count - 1];
            }

            public int Pop()
            {
                // Write your code here.
                minMaxStack.RemoveAt(minMaxStack.Count - 1);
                var val = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return val;
            }

            public void Push(int number)
            {
                // Write your code here.
                Dictionary<string, int> newMinMax = new Dictionary<string, int>();
                newMinMax.Add("min", number);
                newMinMax.Add("max", number);
                //update the min and max in stack
                if (minMaxStack.Count > 0)
                {
                    Dictionary<string, int> lastMinMax = new Dictionary<string, int>(minMaxStack[minMaxStack.Count - 1]);
                    newMinMax["min"] = Math.Min(lastMinMax["min"], number);
                    newMinMax["max"] = Math.Max(lastMinMax["max"], number);
                }
                minMaxStack.Add(newMinMax);
                stack.Add(number);
            }

            public int GetMin()
            {
                // Write your code here.
                return minMaxStack[minMaxStack.Count - 1]["min"];
            }

            public int GetMax()
            {
                // Write your code here.
                return minMaxStack[minMaxStack.Count - 1]["max"];
            }
        }
    }
}