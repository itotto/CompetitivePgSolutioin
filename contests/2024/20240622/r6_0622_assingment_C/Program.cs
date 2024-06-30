using System.Collections.Generic;

namespace r6_0622_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var s_x = Convert.ToInt64(cs1[0]);
            var s_y = Convert.ToInt64(cs1[1]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;
            var t_x = Convert.ToInt64(cs2[0]);
            var t_y = Convert.ToInt64(cs2[1]);

            // Y方向は必ず境界をまたぐ
            var cost = Math.Abs(t_y - s_y);

            var diffx = Math.Abs(t_x - s_x);

            // Y方向の移動だけでは済まない場合はX方向も計算する
            if (cost < diffx) {
                if (s_x > t_x) {
                    if ((s_x + s_y) % 2 == 1) { // 奇数の場合は左に寄せる
                        s_x--;
                    }
                    if (s_x != t_x) {
                        if ((t_x + t_y) % 2 == 0) { // 偶数の場合は右に寄せる
                            t_x++;
                        }
                    }
                } else {
                    if ((s_x + s_y) % 2 == 0) { // 偶数の場合は右に寄せる
                        s_x++;
                    }
                    if (s_x != t_x) {
                        if ((t_x + t_y) % 2 == 1) { // 奇数の場合は左に寄せる
                            t_x--;
                        }
                    }
                }
                var addCost = Math.Abs(t_x - s_x) - cost;
                cost += addCost % 2 == 0 ? addCost / 2 : addCost / 2 + 1;
            }
            Console.WriteLine(cost);
        }
    }
}
