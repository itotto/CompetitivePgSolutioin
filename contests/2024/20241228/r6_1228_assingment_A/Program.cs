using System.Collections.Generic;

namespace r6_1228_assingment_A {
    internal class Program {
        /// <summary>
        /// Full House 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc386/tasks/abc386_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var nums = new List<int>();
            for (var i = 0; i <= 3; i++) {
                nums.Add(Convert.ToInt32(conditions[i]));
            }
            nums.Sort((x,y) => x - y);
            // パターン：a a a b
            if (nums[0] == nums[2] && nums[2] != nums[3]) {
                Console.WriteLine("Yes");

            // パターン：a b b b
            } else if (nums[0] != nums[1] && nums[1] == nums[3]) {
                Console.WriteLine("Yes");

            // パターン：a a b b
            } else if (nums[0] == nums[1] && nums[2] == nums[3] && nums[0] != nums[3]) {
                Console.WriteLine("Yes");

            } else {
                Console.WriteLine("No");
            }
        }
    }
}
