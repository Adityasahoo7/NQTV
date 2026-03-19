using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV
{
    public  class FairSum
    {
        public static int sum(int n, int[] arr)
        {
            int sum = 0;
            int maxcount = arr[0];

            for(int i = 1; i < n; i++)
            {
                if ((arr[i] >= 0 && maxcount > 0) || arr[i] <= 0 && maxcount < 0)
                {
                    maxcount = Math.Max(maxcount, arr[i]);

                }
                else {
                    sum += maxcount;
                    maxcount = arr[i];

                
                }
            }

            sum += maxcount;

            return sum;
        }
        public static void Main(string[] args) {
            Console.Write("Enter the number o element in array : ");
            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) {

                Console.Write("Enter The Element of the array in " + i + " Position : ");
                arr[i] = int.Parse(Console.ReadLine());

            
            }

            int result = sum(num, arr);
                        Console.WriteLine(result);


        }

    }
}
