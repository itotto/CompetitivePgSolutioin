using System.Collections.Generic;

namespace r6_0706_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Intesection of Cuboids
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc361/tasks/abc361_b</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var a = Convert.ToInt32(cs1[0]);
            var b = Convert.ToInt32(cs1[1]);
            var c = Convert.ToInt32(cs1[2]);
            var d = Convert.ToInt32(cs1[3]);
            var e = Convert.ToInt32(cs1[4]);
            var f = Convert.ToInt32(cs1[5]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;
            var g = Convert.ToInt32(cs2[0]);
            var h = Convert.ToInt32(cs2[1]);
            var i = Convert.ToInt32(cs2[2]);
            var j = Convert.ToInt32(cs2[3]);
            var k = Convert.ToInt32(cs2[4]);
            var l = Convert.ToInt32(cs2[5]);

            var result = false;

            // 
            if ((a <= g && g < d) &&
                (b <= h && h < e) &&
                (c <= i && i < f)) {
                result = true;
            } else if ((a <= g && g < d) &&
                       (b <= h && h < e) &&
                       (c < l && l <= f)) {
                result = true;
            } else if ((a < j && j <= d) &&
                       (b <= h && h < e) &&
                       (c <= i && i < f)) {
                result = true;
            } else if ((a < j && j <= d) &&
                       (b <= h && h < e) &&
                       (c < l && l <= f)) {
                result = true;

            } else if ((a <= g && g < d) &&
                       (b < k && k <= e) &&
                       (c < l && l <= f)) {
                result = true;
            } else if ((a <= g && g < d) &&
                       (b < k && k <= e) &&
                       (c <= i && i < f)) {
                result = true;
            } else if ((a < j && j <= d) &&
                       (b < k && k <= e) &&
                       (c <= i && i < f)) {
                result = true;
            } else if ((a < j && j <= d) &&
                       (b < k && k <= e) &&
                       (c < l && l <= f)) {
                result = true;
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
