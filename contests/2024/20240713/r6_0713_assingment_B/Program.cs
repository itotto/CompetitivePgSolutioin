using System.Collections.Generic;

namespace r6_0713_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Right Triangle
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc362/tasks/abc362_b</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var x_a = Convert.ToInt32(cs1[0]);
            var y_a = Convert.ToInt32(cs1[1]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;
            var x_b = Convert.ToInt32(cs2[0]);
            var y_b = Convert.ToInt32(cs2[1]);

            var cs3 = Console.ReadLine()?.Split(' ');
            if (cs3 == null) return;
            var x_c = Convert.ToInt32(cs3[0]);
            var y_c = Convert.ToInt32(cs3[1]);

            var isRightAngle = false;

            // AB - AC の内積
            var x_ab = x_b - x_a;
            var y_ab = y_b - y_a;

            var x_ac = x_c - x_a;
            var y_ac = y_c - y_a;

            isRightAngle = (x_ab * x_ac + y_ab * y_ac) == 0;


            // BA - BC の内積
            if (!isRightAngle) {
                var x_ba = x_a - x_b;
                var y_ba = y_a - y_b;

                var x_bc = x_c - x_b;
                var y_bc = y_c - y_b;

                isRightAngle = (x_ba * x_bc + y_ba * y_bc) == 0;
            }

            // CA - CB の内積
            if (!isRightAngle) {
                var x_ca = x_a - x_c;
                var y_ca = y_a - y_c;

                var x_cb = x_b - x_c;
                var y_cb = y_b - y_c;

                isRightAngle = (x_ca * x_cb + y_ca * y_cb) == 0;
            }

            Console.WriteLine(isRightAngle ? "Yes" : "No");
        }
    }
}
