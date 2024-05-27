using System.Collections.Generic;

namespace r6_0525_assingment_D {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var ranges = new List<KeyValuePair<int, int>>();

            // 入力
            var vMax = -1;
            for (var i = 0; i < n; i++) {
                var range = Console.ReadLine()?.Split(' ');
                if (range == null) return;
                var vFrom = Convert.ToInt32(range[0]);
                var vTo = Convert.ToInt32(range[1]);
                ranges.Add(new KeyValuePair<int, int>(vFrom, vTo));
                if (vMax < vTo) vMax = vTo;
            }

            var t = new int[vMax + 1];
            for (var i = 0; i <= vMax; i++) t[i] = 0;

            foreach (var r in ranges) {
            }

        }
    }
}
