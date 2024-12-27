using System.Collections.Generic;

namespace r6_1221_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Santa Claus 1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc385/tasks/abc385_b</remarks>
        static void Main() {
            static string getkey(int v1, int v2) => $"{v1:000},{v2:000}";

            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var height = Convert.ToInt32(conditions1[0]);
            var width = Convert.ToInt32(conditions1[1]);
            var x = Convert.ToInt32(conditions1[2]);
            var y = Convert.ToInt32(conditions1[3]);

            var map = new char[height, width];
            for (var i = 0; i < height; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < line.Length; j++) {
                    map[i, j] = line[j];
                }
            }

            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(t)) return;

            var totalCount = 0;
            var passed = new Dictionary<string, bool>();

            if (map[x - 1, y - 1] == '@') {
                passed.Add($"{x - 1:000},{y - 1::000}", true);
                totalCount++;
            }

            for (var i = 0; i < t.Length; i++) {
                var order = t[i];

                var nextX = x;
                var nextY = y;

                switch (order) {
                    case 'U':
                        nextX--;
                        break;
                    case 'D':
                        nextX++;
                        break;
                    case 'L':
                        nextY--;
                        break;
                    case 'R':
                        nextY++;
                        break;
                }
                
                // 範囲外の場合は次に行く
                if (nextX < 1 || height < nextX || nextY < 1 || width < nextY) continue;
                if (map[nextX - 1, nextY - 1] == '#') continue;

                x = nextX;
                y = nextY;

                // 家が建っていたら
                if (map[x - 1, y - 1] == '@') {
                    var key = getkey(x - 1, y - 1);

                    // まだ通っていなければ
                    if (!passed.ContainsKey(key)) {
                        passed.Add(key, true);
                        totalCount++;
                    }
                }
            }
            // 結果を出力
            Console.WriteLine($"{x} {y} {totalCount}");
        }
    }
}
