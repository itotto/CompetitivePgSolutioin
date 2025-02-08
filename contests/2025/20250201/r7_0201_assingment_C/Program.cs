using System.Collections.Generic;
using System.Text;

namespace r7_0201_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Pigeonhole Query
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc391/tasks/abc391_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            // 巣にいる鳩の数を初期化
            var holePigeonCounts = new Dictionary<int, int>(n);
            for (var i = 1; i <= n; i++) holePigeonCounts.Add(i, 1);

            var pigeonPositions = new Dictionary<int, int>(n);
            for (var i = 1; i <= n; i++) pigeonPositions.Add(i, i);

            var multipleCounts = 0;

            var output = new StringBuilder();
            for (var i = 0; i < q; i++) {
                var inputs = Console.ReadLine()?.Split(' ');
                if (inputs == null) return;
                if (inputs.Length == 1) output.AppendLine(multipleCounts.ToString());
                else {
                    var target_pigeon = Convert.ToInt32(inputs[1]);
                    var next_pigeon_pos = Convert.ToInt32(inputs[2]);

                    var p_current_pos = pigeonPositions[target_pigeon];

                    pigeonPositions[target_pigeon] = next_pigeon_pos;

                    // 今までいた巣に1匹しか残らなくなった場合は 複数の巣が1つ減る
                    holePigeonCounts[p_current_pos]--;
                    if (holePigeonCounts[p_current_pos] == 1) multipleCounts--;

                    // 移動後の巣に2匹いる場合は 複数の巣が1つ増える
                    holePigeonCounts[next_pigeon_pos]++;
                    if (holePigeonCounts[next_pigeon_pos] == 2) multipleCounts++;
                }
            }
            Console.WriteLine(output.ToString());
        }
    }
}
