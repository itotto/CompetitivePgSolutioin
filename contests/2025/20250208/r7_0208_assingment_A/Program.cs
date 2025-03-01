using System.Collections.Generic;

namespace r7_0208_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Shuffled Equation 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc392/tasks/abc392_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var nums = new List<int>();
            foreach (var c in conditions) {
                nums.Add(Convert.ToInt32(c));
            }
            nums.Sort();
            var result = nums[0] * nums[1];
            Console.WriteLine(result == nums[2] ? "Yes" : "No");
        }
    }
}
