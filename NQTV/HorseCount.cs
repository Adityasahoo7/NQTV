using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV
{
    public class HorseCount
    {
        public static int bet(int n, int k, int[] arr) {
            int start = 0;
            int sum = 0;
            int maxlength = 0;

            for (int end = 0; end < n; end++) {
                sum += arr[end];

                while (sum >= k && start <= end) {

                    sum -= arr[start];
                    start++;
                }

                int currentlength = (end - start) + 1;
                maxlength = Math.Max(maxlength, currentlength);

            
            
            
            }

            return maxlength;
        
        
        }
        
       // public static void Main(string[] args)
       public static void demo()
        {
            Console.Write("Enter the Number Of element in Array");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter the Bet Amount");
            int knum = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++) {

                Console.Write("Enter the Element of the array of " + i + " Position ");
                arr[i] = int.Parse(Console.ReadLine());
            
            }

            int result = bet(num, knum, arr);
            Console.WriteLine(result);



           
        }
    }
}
