namespace Harshad_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // June 2021 Paper 1

            Console.WriteLine("Enter nth Harshad: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{input} Harshad is: {nthHarshad(input)}");
        }

        static bool isHarshad(int n)
        {
            int sum = 0;
            foreach (char d in Convert.ToString(n))
            {
                int digit = Convert.ToInt32(d) - '0';
                sum += digit;
            }
            return n % sum == 0;
        }

        static int nthHarshad(int n)
        {
            int numsFound = 0;
            int i = 0;

            while (numsFound < n)
            {
                i++;
                if (isHarshad(i)) numsFound++;
            }
            return i;
        }
    }
}
