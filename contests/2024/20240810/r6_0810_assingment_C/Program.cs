using System.Collections.Generic;
using System.Text;

namespace r6_0810_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Balls and Bag Query 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc366/tasks/abc366_c</remarks>
        static void Main() {
            var countOfQueries = Convert.ToInt32(Console.ReadLine());

            var ballsState = new Dictionary<int, int>();

            var result = new StringBuilder();
            for (var i = 0; i < countOfQueries; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                if (cs.Length == 1) result.AppendLine(ballsState.Count.ToString());
                else {
                    var orderNumber = Convert.ToInt32(cs[0]);
                    var targetBallNumber = Convert.ToInt32(cs[1]);
                    if (orderNumber == 1) {
                        if (ballsState.ContainsKey(targetBallNumber)) ballsState[targetBallNumber]++;
                        else ballsState.Add(targetBallNumber, 1);
                    } else if (orderNumber == 2) {
                        ballsState[targetBallNumber]--;
                        if (ballsState[targetBallNumber] == 0) ballsState.Remove(targetBallNumber);
                    }
                }
            }

            // 結果を出力
            if (result.Length > 0) {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
