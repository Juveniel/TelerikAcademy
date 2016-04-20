using System;

namespace _04.PersianRugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

           
            string triangle = new string(' ', d) + "\\.../" + new string(' ', d);
            int whSpace = (((n * 2) + 1) - 6);
            int whSpaceD = (n * 2) - 1;
           
            
            for (int i = 0; i < n; i++){
                if(i == 1 && d < n)
                {
                    triangle = new string(' ', d) + "\\./" + new string(' ', d);
                }
                else if(i > 1 && d < n)
                {
                    triangle = new string(' ', whSpace);
                }
                else if(d > n)
                {
                    triangle = new string(' ', whSpaceD);
                }

                Console.WriteLine(new string('#', i) + "\\" + triangle + "/" + new string('#', i));

                if(i > 1 && d < n)
                {
                    whSpace -= 2;
                }
                whSpaceD-=2;
            }

            Console.WriteLine(new string('#', n) + "X" + new string('#', n));


            string triangleBottom = "";
            int whSpaceO = 1;
            int whSpaceB = 1;
            for (int j = n; j > 0; j--)
            {
                if (j > 2 && d < n)
                {                 
                    triangleBottom = new string(' ', whSpaceO);
                }
                if (j == 2 && d < n)
                {
                    triangleBottom = new string(' ', d) + "/.\\" + new string(' ', d);
                }
                else if(j == 1 && d < n)
                {
                    triangleBottom = new string(' ', d) + "/...\\" + new string(' ', d);
                }
                else if (d > n)
                {
                    triangleBottom = new string(' ', whSpaceB);
                }

                Console.WriteLine(new string('#', j - 1) + "/" + triangleBottom + "\\" + new string('#', j - 1));

                whSpaceO += 2;
                whSpaceB += 2;
            }
        }
    }
}
