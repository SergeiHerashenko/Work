//Звичайний варіант.
//Занданий зразу масив та задано значення константи.


using System;

namespace Task_One_V3
{
    class Program
    {
        public static int[] SumaDvokhChysel(int target)
        {
            //Заданий масив цілих чисел
            int[] nums = new int[5] {3, 6, 11, 15, 4};

            //Починаючи з 0-го елемента підсумовуємо елементи і порівнюємо зі змінною
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine("[{0},{1}]", i, j);
                        break;
                    }
                }
                break;
            }

            return nums;
        }

        static void Main(string[] args)
        {
            int target = 9;

            SumaDvokhChysel(target);
        }
    }
}
