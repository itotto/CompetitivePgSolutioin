using System.Collections.Generic;

namespace r6_1026_assingment_E {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt64(conditions[1]);

            // key:数値, value:場所
            var nums = new Dictionary<int, int>();
            var numList = new List<int>();

            // 入力
            var data = Console.ReadLine()?.Split(' ');
            if (data == null) return;
            for (var i = 0; i < data.Length; i++) {
                var d = Convert.ToInt32(data[i]);
                nums.Add(d, i + 1);
                numList.Add(d);
            }

            // 計算
            for (var i = 0; i < k; i++) {
                var replaeced = new Dictionary<int, int>();
                var replaecedList = new List<int>();

                //for (var j = 0; j < nums.Count; j++) {
                foreach (var num in numList) {

                }

                nums = replaeced;
                numList = replaecedList;
            }

            var ans = new int[nums.Count];
            foreach (var d in nums) {
                ans[d.Value - 1] = d.Key;
            }

            Console.Write(ans[0]);
            for (var i = 1; i < ans.Length; i++) {
                Console.Write($" {ans[i]}");
            }
            Console.WriteLine();

        }
    }
}
