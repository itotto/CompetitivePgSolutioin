using System.Collections.Generic;

namespace r6_0824_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Triple Attack
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc368/tasks/abc368_c</remarks>
        static void Main() {
            var countOfEnemies = Convert.ToInt32(Console.ReadLine());

            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var enemiesHp = new List<int>();
            foreach (var c in conditions1) {
                enemiesHp.Add(Convert.ToInt32(c));
            }

            //enemiesHp.Sort((x,y) => x - y); // 昇順にソート

            long t = 0;
            var idx = 0;
            var lastPos = enemiesHp.Count - 1;
            //while (idx >= enemiesHp.Count) {
            while (idx <= lastPos) {
                if (enemiesHp[idx] > 5) {
                    var attackUnit = enemiesHp[idx] / 5;
                    enemiesHp[idx] = enemiesHp[idx] % 5;
                    t += attackUnit * 3;
                } else {
                    t++;
                    enemiesHp[idx] -= t % 3 == 0 ? 3 : 1;
                }
                if (enemiesHp[idx] <= 0) idx++;
            }

            Console.WriteLine(t);
        }
    }
}
