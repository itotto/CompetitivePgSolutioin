using System.Collections.Generic;

namespace r7_0607_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Citation 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc409/tasks/abc409_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var a_i = Console.ReadLine()?.Split(' ');
            if (a_i == null) return;

            var nCounts = new Dictionary<long, int>();
            for (var i = 0; i < n; i++) {
                var a = Convert.ToInt64(a_i[i]);
                if (nCounts.ContainsKey(a)) nCounts[a]++;
                else nCounts.Add(a, 1);
            }
            var nums = nCounts.Keys.ToList();
            nums.Sort();

            long maxNum = nums[0] ;
            var biggers = n;
            for (var i = nums[0]; i < nums[nums.Count - 1]; i++) {
                if (i <= biggers) {
                    maxNum = i;
                }
                if (nCounts.ContainsKey(i)) {
                    biggers -= nCounts[i];
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
