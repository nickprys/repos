using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary4
{
    public class OrderPro
    {
           public  int[] nums = new int[7];
        
  

    // сортировка


           public int temp;
            for (int i = 0; i<nums.Length - 1; i++)
            {
                for (int j = i + 1; j<nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i<nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

            }
}
