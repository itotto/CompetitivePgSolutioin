using System.Collections.Generic;

namespace _19_WalkingTakahashi {
    internal class Program {
        /// <summary>
        /// C - Walking Takahashi
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc175/tasks/abc175_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var startPos = Convert.ToInt64(conditions[0]);
            var countOfMoving = Convert.ToInt64(conditions[1]);
            var unitOfDistance = Convert.ToInt64(conditions[2]);

            // 負側にいる場合は位置を逆にする
            if (startPos < 0) startPos *= -1;

            var countOfNearZero = startPos / unitOfDistance;

            // 一番ゼロに近づくための回数よりも移動可能回数が少ない場合
            if (countOfNearZero >= countOfMoving) {
                countOfNearZero = countOfMoving;
            }

            long minPos = startPos - countOfNearZero * unitOfDistance;

            // 残移動可能回数
            var leftCount = countOfMoving - countOfNearZero;

            // まだ移動可
            if (leftCount >= 1) {
                long nextPos = (minPos - unitOfDistance) * -1;
                // 次の移動候補がもっとゼロに近い場合は移動
                if (nextPos <= minPos) {
                    minPos = nextPos;
                    leftCount--;
                }

                // まだ移動可
                if (leftCount >= 1) {
                    // 
                    if (leftCount % 2 == 1) {
                        minPos = minPos > 0 ? minPos - unitOfDistance : minPos + unitOfDistance;
                    }
                }
            }
            Console.WriteLine(minPos > 0 ? minPos : minPos * -1);
        }
    }
}
