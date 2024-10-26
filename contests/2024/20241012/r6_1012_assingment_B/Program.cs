using System.Collections.Generic;

namespace r6_1012_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Traveling Takahashi Problem
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc375/tasks/abc375_b</remarks>
        static void Main() {
            var countOfCoodinates = Convert.ToInt32(Console.ReadLine());

            double distance = 0;

            long current_X = 0;
            long current_Y = 0;
            for (var i = 0; i < countOfCoodinates; i++) {
                var condition1 = Console.ReadLine()?.Split(' ');
                if (condition1 == null) return;
                var next_X = Convert.ToInt64(condition1[0]);
                var next_Y = Convert.ToInt64(condition1[1]);

                long move = (current_X - next_X) * (current_X - next_X) + (current_Y - next_Y) * (current_Y - next_Y);
                distance += Math.Sqrt(move);

                // 移動
                current_X = next_X;
                current_Y = next_Y;
            }
            
            var lastMove = current_X * current_X + current_Y * current_Y;
            distance += Math.Sqrt(lastMove);

            Console.WriteLine(distance);
        }
    }
}
