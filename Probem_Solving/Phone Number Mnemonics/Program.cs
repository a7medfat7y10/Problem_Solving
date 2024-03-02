namespace Phone_Number_Mnemonics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string str in PhoneNumberMnemonics("1905"))
                Console.WriteLine(str);
        }
        //On*4^n) time / On*4^n) space
        static Dictionary<char, string[]> digits = new Dictionary<char, string[]>{
            {'0', new string[] {"0"}},
            {'1', new string[] {"1"}},
            {'2', new string[] {"a", "b", "c"}},
            {'3', new string[] {"d" , "e", "f"}},
            {'4', new string[] {"g", "h", "i"}},
            {'5', new string[] {"k" , "k" , "l"}},
            {'6', new string[] {"m" , "n","o"}},
            {'7', new string[] {"p" , "q" , "r" , "s"}},
            {'8', new string[] {"t" , "u" , "v"}},
            {'9', new string[] {"w" , "x" ,"y" , "z"}}
        };
        public static List<string> PhoneNumberMnemonics(string phoneNumber)
        {
            // Write your code here.
            string[] currentMnemonic = new string[phoneNumber.Length];
            Array.Fill(currentMnemonic, "0");
            List<string> mnemonicsFound = new List<string>();
            PhoneNumberMnemonics(phoneNumber, currentMnemonic, mnemonicsFound, 0);
            return mnemonicsFound;
        }
        public static void PhoneNumberMnemonics(string phoneNumber, string[] currentMnemonic, List<string> mnemonicsFound, int indx)
        {
            if (indx == phoneNumber.Length)
            { // Mnemonics just composed in currentMnemonic
                mnemonicsFound.Add(String.Join("", currentMnemonic));
            }
            else
            {
                //starting from 0 at the first call
                char digit = phoneNumber[indx];
                foreach (var letter in digits[digit])
                {
                    currentMnemonic[indx] = letter;
                    PhoneNumberMnemonics(phoneNumber, currentMnemonic, mnemonicsFound, indx + 1);
                }
            }
        }
    }
}