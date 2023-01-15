using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
  public  class PrimeNumber
    {
        public void FindPrimeNo()
        {
            bool prime = true;
            Console.WriteLine("Enter the Range to get the prime no from that : ");




            for (int a = 2; a <= 1000; a++)
            {
                for (int b = 2; b <= 1000; b++)
                {
                    if (a != b && a % b == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime)
                {
                    Console.Write("\t" + a);
                }
                prime = true;

            }

            Console.ReadLine();


        }
    }

}