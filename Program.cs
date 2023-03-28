namespace BubbleSort
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers1 = { };
            DisplayTable(numbers1);
            BubbleSort(numbers1);
            int[] numbers2 = { 1, 2, 5, 3, 1, 7, 9, 1, 12, 83, 1, 5, 3, 2 };
            DisplayTable(numbers2);
            BubbleSort(numbers2);
            int[] numbers3 = { 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1 };
            DisplayTable(numbers3);
            BubbleSort(numbers3);
            int[] numbers4 = { 2, 2, 2, 2 };
            DisplayTable(numbers4);
            BubbleSort(numbers4);
            int[] numbers5 = { 1, 2 };
            DisplayTable(numbers5);
            BubbleSort(numbers5);
            int[] numbers6 = { 2, 1 };
            DisplayTable(numbers6);
            BubbleSort(numbers6);
        }
      


        static void BubbleSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                bool change = false;
                for (int j = 0; j < numbers.Length - 1; j++) 
                {
                  if (numbers[j] > numbers[j + 1])
                  {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        change = true;
                  }
                }
                if (!change) break;
                DisplayTable(numbers);
            }
            Console.WriteLine();
        }

        static void DisplayTable(int[] numbers)
        {
            for (int i = 0;i < numbers.Length;i++)
            {
                Console.Write($"[{numbers[i]}]");
            }
            Console.WriteLine();
        }
    }
}