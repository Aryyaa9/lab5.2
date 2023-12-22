using System;
using System.IO;
using System.Linq;
namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask5.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();

                int[] nums = str.Split(' ').Select(int.Parse).ToArray();

                int max = nums[0], min = nums[0];
                int minNum = 0, maxNum = 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                        maxNum = i;
                    }

                    if (nums[i] < min)
                    {
                        min = nums[i];
                        minNum = i;
                    }
                }

                int sum = 0;

                for (int i = minNum + 1; i < maxNum; i++)
                {
                    sum += nums[i];
                }

                Console.WriteLine("Average: " + (double)sum / (double)(maxNum - minNum - 1));
            }
        }
    }
}