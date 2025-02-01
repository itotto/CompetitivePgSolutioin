using System.Collections.Generic;

namespace r7_0125_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Paint to make a rectangle
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc390/tasks/abc390_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var height = Convert.ToInt32(conditions1[0]);
            var width = Convert.ToInt32(conditions1[1]);

            var topPos = -1;
            var bottomPos = -1;
            var leftPos = -1;
            var rightPos = -1;

            var blackMass = new Dictionary<string, bool>();
            var whiteMass = new Dictionary<string, bool>();

            // マスを入力
            for (var i = 0; i < height; i++) {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) continue;
                for (var j = 0; j < width; j++) {
                    var key = $"{i}__{j}";
                    var v = s[j];

                    // 黒のときだけチェック
                    if (v == '#') {
                        blackMass.Add(key, true);
                        if (topPos == -1) topPos = i;
                        if (i > bottomPos) bottomPos = i;
                        if (leftPos == -1 || leftPos > j) leftPos = j;
                        if (j > rightPos) rightPos = j;
                    } else if (v == '.') {
                        whiteMass.Add(key, true);
                    }
                }
            }

            var result = blackMass.Count == 1;
            if (!result) {
                result = true;
                for (var i = topPos; i <= bottomPos; i++) {
                    for (var j = leftPos; j <= rightPos; j++) {
                        var key = $"{i}__{j}";
                        if (whiteMass.ContainsKey(key)) {
                            result = false;
                            break;
                        }
                    }
                    if (!result) break;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
