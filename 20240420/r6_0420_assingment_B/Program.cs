using System.Collections.Generic;

namespace r6_0420_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Dentist Aoki 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc350/tasks/abc350_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var countOfTeeth = Convert.ToInt32(conditions[0]);
            _ = Convert.ToInt32(conditions[1]);

            var treats = Console.ReadLine()?.Split(' ');
            if (treats == null) return;

            // 歯の状態を初期化
            var teethState = new Dictionary<string, bool>();
            for (var i = 1; i <= countOfTeeth; i++) {
                teethState.Add(i.ToString(), true);
            }

            // 治療
            foreach (var t in treats) {
                if (teethState.ContainsKey(t)) {
                    teethState[t] = !teethState[t];
                } else { // こっちは通らないはず
                    teethState.Add(t, true);
                }
            }

            // 集計
            var cnt = 0;
            foreach (var t in teethState) {
                if (t.Value) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
