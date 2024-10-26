using System.Collections.Generic;

namespace r6_1026_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Avoid Knight Attack
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc377/tasks/abc377_c</remarks>
        static void Main() {
            // input
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // マス目は n x n
            long amountOfCells = (long)n * (long)n;

            // key: y-x, value:dummy
            var ngLocations = new Dictionary<string, bool>();

            // 
            for (var i = 0; i < m; i++) {
                var location = Console.ReadLine()?.Split(' ');
                if (location == null) return;
                var y = Convert.ToInt32(location[0]);
                var x = Convert.ToInt32(location[1]);

                var ngLoc = GetNgLocation(y, x, n);
                if (ngLoc.Count > 0) {
                    foreach (var ng in ngLoc) {
                        if (!ngLocations.ContainsKey(ng)) {
                            ngLocations.Add(ng, true);
                        }
                    }
                }
            }

            // 
            Console.WriteLine(amountOfCells - ngLocations.Count);
        }

        static List<string> GetNgLocation(int y, int x, int maxPos) {
            var r = new List<string>() { $"{y}-{x}" };

            // y + 2, x + 1
            if ((y + 2) <= maxPos && (x + 1) <= maxPos) {
                r.Add($"{y + 2}-{x + 1}");
            }

            // y + 1, x + 2
            if ((y + 1) <= maxPos && (x + 2) <= maxPos) {
                r.Add($"{y + 1}-{x + 2}");
            }

            // y - 1, x + 2
            if ((y - 1) > 0 && (x + 2) <= maxPos) {
                r.Add($"{y - 1}-{x + 2}");
            }

            // y - 2, x + 1
            if ((y - 2) > 0 && (x + 1) <= maxPos) {
                r.Add($"{y - 2}-{x + 1}");
            }

            // y - 2, x - 1
            if ((y - 2) > 0 && (x - 1) > 0) {
                r.Add($"{y - 2}-{x - 1}");
            }

            // y - 1, x - 2
            if ((y - 1) > 0 && (x - 2) > 0) {
                r.Add($"{y - 1}-{x - 2}");
            }

            // y + 1, x - 2
            if ((y + 1) <= maxPos && (x - 2) > 0) {
                r.Add($"{y + 1}-{x - 2}");
            }

            // y + 2, x - 1
            if ((y + 2) <= maxPos && (x - 1) > 0) {
                r.Add($"{y + 2}-{x - 1}");
            }

            return r;
        }
    }
}
