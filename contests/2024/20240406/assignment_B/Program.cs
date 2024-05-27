using System.Collections.Generic;

namespace assignment002 {
    internal class Program {
        static void Main() {
            string getKey(int k1, int k2) => k1 >= k2 ? $"{k2}{k1}" : $"{k1}{k2}";

            var n = Convert.ToInt32(Console.ReadLine());
            var list = new List<Coodinate>();

            for (var i = 0; i < n; i++) {
                var positions = Console.ReadLine()?.Split(' ');
                if (positions == null) return;
                var x = Convert.ToInt32(positions[0]);
                var y = Convert.ToInt32(positions[1]);
                list.Add(new Coodinate { X = x, Y = y });
            }

            var farthestTargets = new Dictionary<int, int>();
            for (var i = 0; i < n; i++) {
                var x1 = list[i].X;
                var y1 = list[i].Y;

                var maxDistance = double.MinValue;
                for (var j = 0; j < n; j++) {
                    if (i == j) continue;
                    var x2 = list[j].X;
                    var y2 = list[j].Y;

                    var d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                    if (d > maxDistance) {
                        maxDistance = d;
                        if (farthestTargets.ContainsKey(i + 1)) {
                            farthestTargets[i + 1] = j + 1;
                        } else farthestTargets.Add(i + 1, j + 1);
                    }
                }
            }

            for (var i = 1; i <= n; i++) {
                Console.WriteLine(farthestTargets[i]);
            }
        }

        struct Coodinate {
            public int X { get; set; }
            public int Y { get; set; }
        }

    }
}
