namespace One_Edit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OneEdit("hello" ,"hallo"));
        }
        //O(n) time / O(1) space
        public static bool OneEdit(string stringOne, string stringTwo)
        {
            // Write your code here.
            if (stringOne == stringTwo)
                return true;
            if (Math.Abs(stringOne.Length - stringTwo.Length) > 1)
                return false;
            bool isEdited = false;
            int i = 0;
            int j = 0;
            while (i < stringOne.Length && j < stringTwo.Length)
            {
                if (stringOne[i] != stringTwo[j])
                {
                    if (isEdited == true)
                        return false;
                    isEdited = true;

                    if (stringTwo.Length > stringOne.Length)
                        j++;
                    else if (stringOne.Length > stringTwo.Length)
                        i++;
                    else
                    {
                        i++;
                        j++;
                    }
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return true;
        }
    }
}