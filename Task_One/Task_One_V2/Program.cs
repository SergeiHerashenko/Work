//Другий варіант розвязку.
//Майже теж саме що й в першому варіанті, але вже ми завершуемо програму, тоді коли знайденно хоча б одну пару індексів.


using System;

namespace Task_One_V2
{
    class Program
    {
        public static int[] SumaDvokhChysel(int target, string[] Value_Array)
        {
            //Заданий масив цілих чисел
            int[] nums = new int[Value_Array.Length];

            for (int i = 0; i < Value_Array.Length; i++)
            {
                nums[i] = Convert.ToInt32(Value_Array[i]);
            }

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
            //Просимо користувача заповнити масив
            Console.WriteLine("Please, enter the length of the array:");

            string[] Value_Array = Console.ReadLine().Split(' ');

            //Просимо користувача ввести значення змінної target
            Console.WriteLine("Plese, enter target");

            int target = int.Parse(Console.ReadLine());

            SumaDvokhChysel(target, Value_Array);

        }
    }
}
