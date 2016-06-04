using System;
using System.Linq;
using System.Numerics;

class BunnyFactory
{
    static void Main()
    {
        string currentCage = Console.ReadLine();
        int[] cages = new int[205];
        // List<int> cages new List<int>();
        int n = 0;

        while (currentCage != "END")
        {
            cages[n] = int.Parse(currentCage);
            //cages.Add(int.Parse(currentCage));
            n++;

            currentCage = Console.ReadLine();
        }

        for (int i = 1; i < n; i++)
        {          
            int s = 0;

            for (int j = 0; j < i; j++)
            {
                s += cages[j];
            }

            if(n - i < s)
            {
                break;
            }

            int sum = 0;
            BigInteger product = 1;
            for (int k = i; k < i + s; k++)
            {
                sum += cages[k];
                product *= cages[k];
            }

            string next = sum.ToString() + product.ToString();
            for (int j = i + s; j < n; j++)
            {
                next += cages[j].ToString();
            }

            next = next.Replace("0", "").Replace("1", "");

            n = next.Length;
            for (int j = 0; j < n; j++)
            {
                cages[j] = next[j] - '0';
            }       
        }
       
        Console.WriteLine(string.Join(" ", 
            cages.Select(x => x.ToString()).ToArray(), 
            0, n));
    }
}

