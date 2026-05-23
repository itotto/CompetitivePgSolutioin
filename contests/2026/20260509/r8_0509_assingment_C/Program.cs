using System.Collections.Generic;

namespace r8_0509_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Long Sequence
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc457/tasks/abc457_c</remarks>
        static void Main() {
            // N / K 入力
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt64(conditions1[0]);
            var k = Convert.ToInt64(conditions1[1]);

            // A_i_j 入力
            var lengthOfA = new Dictionary<int, int>();
            var data = new Dictionary<int, Dictionary<int, long>>();
            for (var i = 1; i <= n; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;

                var subData = new Dictionary<int, long>();
                for (var j = 1; j < conditions2.Length; j++) {
                    subData.Add(j, Convert.ToInt64(conditions2[j]));
                }
                lengthOfA.Add(i, Convert.ToInt32(conditions2[0]));
                data.Add(i, subData);
            }

            // C_n 入力
            var c_n = new Dictionary<int, int>();
            var conditions3 = Console.ReadLine()?.Split(' ');
            if (conditions3 == null) return;
            for (var i = 0; i <  conditions3.Length; i++) {
                c_n.Add(i + 1, Convert.ToInt32(conditions3[i]));
            }

            for (var i = 1; i <= n; i++) {
                var arrayLen = lengthOfA[i];
                var c = c_n[i];

                // 全部を連結してもKにたどり着かない場合は差し引いて次に行く
                long totalLen = arrayLen * c;
                if (totalLen < k) {
                    k -= totalLen;
                    continue;
                }

                // 0の場合は最後の値にする
                var subIndex = (int)(k % arrayLen);
                if (subIndex == 0) subIndex = arrayLen;

                Console.WriteLine(data[i][subIndex]);
                break;
            }
        }
    }
}
