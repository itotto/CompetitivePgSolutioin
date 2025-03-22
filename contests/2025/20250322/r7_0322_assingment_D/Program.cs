using System.Collections.Generic;
using System.Text;

namespace r7_0322_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Bonfire
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc398/tasks/abc398_d</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var r = Convert.ToInt32(conditions[1]);
            var c = Convert.ToInt32(conditions[2]);

            // 対象座標
            var targetPosition = $"{r}_{c}";
            var originPosition = $"0_0";

            var winds = Console.ReadLine();
            if (string.IsNullOrEmpty(winds)) return;

            var smokes = new List<KeyValuePair<int, int>> { new KeyValuePair<int, int>(0, 0) };

            var result = new StringBuilder(n);
            for (var i = 0; i < winds.Length; i++) {
                var originExists = false;

                var newSmokes = new List<KeyValuePair<int, int>>(smokes.Count + 1);

                // 初期値はN
                var h_move = -1;
                var v_move = 0;

                switch (winds[i]) {
                    case 'W':
                        h_move = 0;
                        v_move = -1;
                        break;
                    case 'S':
                        h_move = 1;
                        v_move = 0;
                        break;
                    case 'E':
                        h_move = 0;
                        v_move = 1;
                        break;
                }

                var targetSurrounded = false;
                // 移動を計算
                for(var j = 0; j < smokes.Count; j++) {
                    var s = smokes[j];
                    var ns = new KeyValuePair<int, int>(s.Key + h_move, s.Value + v_move);
                    var posStr = $"{ns.Key}_{ns.Value}";

                    // 原点があった場合
                    if (posStr == originPosition) originExists = true;

                    // 煙に囲まれている場合
                    else if (posStr == targetPosition) targetSurrounded= true;

                    newSmokes.Add(ns);
                }

                result.Append(targetSurrounded ? "1" : "0");

                // 原点が無ければ追加
                if (!originExists) newSmokes.Add(new KeyValuePair<int, int>(0, 0));

                smokes = newSmokes;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
