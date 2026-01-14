using System.Collections.Generic;

namespace _11_FriendsAndTravelCosts {
    internal class Program {
        /// <summary>
        /// C - Friends and Travel costs
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc203/tasks/abc203_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            var friends = new List<KeyValuePair<long, int>>();

            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var a = Convert.ToInt64(conditions[0]);
                var b = Convert.ToInt32(conditions[1]);

                friends.Add(new KeyValuePair<long, int>(a, b));
            }

            friends.Sort((v1, v2) => v1.Key >= v2.Key ? 1 : -1);

            long current = k;
            var currentIndex = 0;
            while (true) {
                var currentWork = current;
                var currentIndexWork = currentIndex;
                for (var i = currentIndex; i < friends.Count; i++) {
                    var f = friends[i];
                    if (f.Key <= current) {
                        currentWork += f.Value;
                        currentIndexWork = i;
                    } else break;
                }
                if (currentWork == current) break;
                current = currentWork;
                currentIndex = currentIndexWork + 1;
            }

            Console.WriteLine(current);
        }
    }
}
