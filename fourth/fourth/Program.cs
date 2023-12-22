using System;
using System.IO;
using System.Linq;
namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask4.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();

                int[] nums = str.Split(' ').Select(int.Parse).ToArray();

                int max = nums.Max();

                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == max - 1)
                        sum += nums[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}