using System.Collections.Generic;
using System.Text;

namespace r6_0420_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sort
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc350/tasks/abc350_c</remarks>
        static void Main() {
            // 確認用
            bool isSorted(int[] data) {
                for (var i = 1; i < data.Length; i++) {
                    if (data[i] < data[i - 1]) return false;
                }
                return true;
            }

            var n = Convert.ToInt32(Console.ReadLine());

            var data = new int[n];
            var pos = new Dictionary<int, int>();
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            for (var i = 0; i < inputs.Length; i++) {
                data[i] = Convert.ToInt32(inputs[i]);
                pos.Add(data[i], i);
            }

            var result = new StringBuilder();
            var cnt = 0;

            var target = 1;
            while (true) {
                if (isSorted(data)) break;

                var targetPos = pos[target]; // 対象数値の場所を取得
                if (targetPos == target + 1) { // 既に指定の場所にあれば次に行く
                    target++;
                    continue;
                }

                var tmp = data[target - 1];
                data[target - 1] = data[targetPos];
                data[targetPos] = tmp;

                pos[target] = target - 1;
                pos[target] = target - 1;

                cnt++;

            }

            Console.WriteLine(cnt);
            Console.WriteLine(result.ToString());
        }
    }
}
