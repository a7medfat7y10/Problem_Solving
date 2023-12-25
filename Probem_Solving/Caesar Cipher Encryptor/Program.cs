namespace Caesar_Cipher_Encryptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaesarCypherEncryptor("xyz", 2));
        }
        public static string CaesarCypherEncryptor(string str, int key)
        {
            // Write your code here.
            string result = "";
            key = key % 26;
            
            for (int i = 0; i < str.Length; i++)
            {
                int charCode = (str[i] - 'a' + key) % 26 + 'a';
                result += (char) charCode;
            }
            return result;
        }
    }
}