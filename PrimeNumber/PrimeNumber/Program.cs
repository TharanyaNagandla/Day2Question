using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the minimum and maximum");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            
            for(int i=min;i<=max;i++)
            {
                int count = 0;
                for (int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }
                }
                if(count==0 && i!=1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
