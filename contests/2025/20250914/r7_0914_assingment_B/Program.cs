using System.Collections.Generic;

namespace r7_0914_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Locked Rooms
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc423/tasks/abc423_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var isLocked = new bool[n + 1];
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                isLocked[i + 1] = conditions[i] == "1";
            }

            var fromLeft = n;
            for (var i = 1; i <= n; i++) {
                if (isLocked[i]) {
                    fromLeft = i;
                    break;
                }
            }

            var fromRight = 1;
            for (var i = n; i >= 0; i--) {
                if (isLocked[i]) {
                    fromRight = i;
                    break;
                }
            }

            if (fromRight < fromLeft) Console.WriteLine(0);
            else Console.WriteLine(fromRight - fromLeft);
        }
    }
}
