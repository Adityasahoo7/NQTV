using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQTV
{
    public class GoldCoin
    {
        public static void findroom(int n, int k, int[] arr) {

            int start = 0;
            int sum = 0;

            for (int end = 0; end < n; end++) {

                sum += arr[end];

                while(sum>k && start <= end)
                {
                    sum -= arr[start];
                    start++;
                }

                if (sum == k) {

                    Console.WriteLine((start + 1) + " " + (end + 1));
                    return;
                
                }


            
            
            }
        
        
        
        }

       // public static void Main(string[] args) {
       public void code1() { 
            Console.Write("Enter the number of element in array");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter The Sum Value");
            int knum = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the Array element of this " + i + " Position");
                arr[i] = int.Parse(Console.ReadLine());
            }


            findroom(num, knum, arr);

        }
    }
}
