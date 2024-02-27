namespace Valid_IP_Addresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(string ip in ValidIPAddresses("19215810"))
            {
                Console.WriteLine(ip);
            }
        }
        //O(1) time => because the worst case there will be 2^32 possibilties (8bits * 4 parts) / O(1) space
        public static List<string> ValidIPAddresses(string str)
        {
            // Write your code here.
            List<string> allIPAddressesPossible = new List<string>();
            for (int i = 1; i < Math.Min((int)str.Length, 4); i++)
            {
                string[] currentIPParts = new string[] { "", "", "", "" };

                currentIPParts[0] = str.Substring(0, i - 0);
                if (!isValidPart(currentIPParts[0]))
                    continue;

                for (int j = i + 1; j < i + Math.Min((int)str.Length - i, 4); j++)
                {
                    currentIPParts[1] = str.Substring(i, j - i);
                    if (!isValidPart(currentIPParts[1]))
                        continue;

                    for (int k = j + 1; k < j + Math.Min((int)str.Length - j, 4); k++)
                    {
                        currentIPParts[2] = str.Substring(j, k - j);
                        currentIPParts[3] = str.Substring(k);
                        if (isValidPart(currentIPParts[2]) && isValidPart(currentIPParts[3]))
                            allIPAddressesPossible.Add(currentIPParts[0] + "." + currentIPParts[1] + "." + currentIPParts[2] + "." + currentIPParts[3]);
                    }
                }

            }

            return allIPAddressesPossible;
        }
        public static bool isValidPart(string str)
        {
            int intFromString = int.Parse(str);
            if (intFromString > 255)
                return false;
            return str.Length == intFromString.ToString().Length;
        }
    }
}