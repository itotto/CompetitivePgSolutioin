using System.Collections.Generic;

namespace r6_1207_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Humidifier 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc383/tasks/abc383_b</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var height = Convert.ToInt32(cs[0]);
            var width = Convert.ToInt32(cs[1]);
            var thresholdDistance = Convert.ToInt32(cs[2]);

            var squares = new char[height, width];
            var floors = new List<KeyValuePair<int, int>>();
            for (var i = 0; i < height; i++) {
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data)) return;
                for (var j = 0; j < data.Length; j++) {
                    var f = data[j];
                    squares[i, j] = f;
                    if (f == '.') floors.Add(new KeyValuePair<int, int>(i, j));
                }
            }

            // Key:x_y, Value: x_y for heating areas
            var areas = new List<List<string>>();
            foreach (var f in floors) {
                var targetfloors = new List<string>();
                foreach (var targetf in floors) {
                    var distance = Math.Abs(f.Key - targetf.Key) + Math.Abs(f.Value - targetf.Value);
                    if (distance <= thresholdDistance) targetfloors.Add($"{targetf.Key}_{targetf.Value}");
                }
                areas.Add(targetfloors);
            }

            var maxCount = 0;
            for (var i = 0; i < areas.Count - 1; i++) {
                var p1 = areas[i];
                for (var j = i + 1; j < areas.Count; j++) {
                    var p2 = areas[j];

                    var totalCount = p1.Count + p2.Count;
                    var duplicationCount = 0;
                    foreach (var m1 in p1) {
                        foreach (var m2 in p2) {
                            if (m1 == m2) duplicationCount++;
                        }
                    }
                    if (totalCount - duplicationCount > maxCount) {
                        //Console.WriteLine($"total:{totalCount}, maxCount:{maxCount}, duplication:{duplicationCount}, i:{i}, j:{j}");
                        maxCount = totalCount - duplicationCount;
                    }
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
