using System.Formats.Tar;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class II_Q5
{
    public static void LongSeq()
    {
        Console.WriteLine("enter space separated values");
        int[] items = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int[] ans = new int[0];

        int local_cnt = 1;
        int global_cnt = 1;
        int global_start_idx = 0;
        int start_idx = 0;

        for (int i = 1; i < items.Length; i += 1)
        {
            if (items[i] == items[i - 1])
            {
                local_cnt += 1;
                if (local_cnt > global_cnt)
                {
                    global_cnt = local_cnt;
                    global_start_idx = start_idx;
                }
            }
            else
            {
                local_cnt = 1;
                start_idx = i;
            }
        }

        for (int i = global_start_idx; i < global_start_idx + global_cnt; i += 1)
        {
            Array.Resize(ref ans, ans.Length + 1);
            ans[ans.Length - 1] = items[i];
        }

        Console.WriteLine($"the final ans is {String.Join(",", ans)}");
    }
}