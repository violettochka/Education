namespace HM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer");
            int numberOfTiers = 0;
            int left = 0;
            try
            {
                numberOfTiers = Convert.ToInt32(Console.ReadLine());
                left = numberOfTiers;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid data. Please enter a number");
            }


            for(int i = 1; i <= numberOfTiers; i++)
            {
                if (numberOfTiers <= 0)
                {
                    throw new Exception("Invalid data. Please enter a positive integer");
                }
                string indentation = " ".PadLeft(left);
                string temp = new string('$', i * 2 - 1);
                Console.WriteLine(indentation + temp);
                left -= 1;
            }
        }
    }
}
