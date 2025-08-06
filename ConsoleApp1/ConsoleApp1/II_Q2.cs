using System.Runtime.InteropServices;

class II_Q2
{
    public static void Looping()
    {

        string[] arr = new string[0];

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("null input error");
                continue;
            }

            char firstchar = input[0];

            if (firstchar == '+')
            {
                string item = input.Substring(2);
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = item;
                Console.WriteLine($"new item added {String.Join(",", arr)}");
            }
            else if (firstchar == '-')
            {
                string item = input.Substring(2);
                int index = Array.IndexOf(arr, item);
                Console.WriteLine($"index = {index} and arr = {String.Join(",", arr)}");

                if (index >= 0)
                {
                    string[] new_arr = new string[arr.Length - 1];
                    for (int i = 0, j = 0; i < arr.Length; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        new_arr[j++] = arr[i];
                    }
                    arr = new_arr;
                    Console.WriteLine($"Removed: {item}. The array is now {String.Join(",", arr)}");
                }
                else
                {
                    Console.WriteLine($"invalid item");
                }
            }
            else if (firstchar == '_')
            {
                arr = new string[0];
                Console.WriteLine($"the array is cleared. Array = {String.Join(", ", arr)}");
            }
            else
            {
                Console.WriteLine("enter a valid command");
            }
        }

    }
}