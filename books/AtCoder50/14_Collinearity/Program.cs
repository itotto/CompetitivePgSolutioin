using System.Collections.Generic;

namespace _14_Collinearity {
    internal class Program {
        /// <summary>
        /// C - Collinearity
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc181/tasks/abc181_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var points = new List<KeyValuePair<int, int>>();
            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                points.Add(new KeyValuePair<int, int>(
                    key: Convert.ToInt32(conditions[0]),
                    value: Convert.ToInt32(conditions[1])
                ));
            }

            for (var i = 0; i < points.Count - 2; i++) {
                var p1 = points[i];
                for (var j = i + 1; j < points.Count - 1; j++) {
                    var p2 = points[j];

                    var dx = p2.Key - p1.Key;
                    var dy = p2.Value - p1.Value;

                    for (var k = j + 1; k < points.Count; k++) {
                        var p3 = points[k];
                        var dx2 = p3.Key - p1.Key;
                        var dy2 = p3.Value - p1.Value;

                        if (dy2 * dx == dy * dx2) {
                            Console.WriteLine("Yes");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}
