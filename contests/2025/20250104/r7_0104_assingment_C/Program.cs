using System.Collections.Generic;

namespace r7_0104_assingment_C {
    internal class Program {

        static Dictionary<int, long> _snakeNumbers = new Dictionary<int, long>() {
            {2,45 }, {3,285 },{ 4,2025 },{ 5,15333 }, {6,120825 }, {7,978405 }, {8,8080425 }, {9,67731333 }, {10,574304985 },
            {11,4914341925 }, {12,42364319625 }, {13,367428536133 }, {14,3202860761145 }, {15,28037802953445 },
            { 16,246324856379625 }, {17,2170706132009733 }, {18,19179318935377305 }, {19,169842891165484965 },
        };

        /// <summary>
        /// C - Snake Numbers
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var minVStr = conditions[0];
            var maxVStr = conditions[1];

            // 最小値以下のへび数を求める
            long snakeNumCount_min = CountSnakeNumber(minVStr);

            // 最大値以下のへび数を求める
            long snakeNumCount_max = CountSnakeNumber(maxVStr);

            // 最小値がへび数ならその分はカウントする
            var offset = IsSnakeNumber(minVStr) ? 1 : 0;

            //　最大値 - 最小値 + ??
            Console.WriteLine(snakeNumCount_max - snakeNumCount_min + offset);

        }

        /// <summary>
        /// へび数を数える
        /// </summary>
        /// <param name="targetNumStr"></param>
        /// <returns></returns>
        static long CountSnakeNumber(string targetNumStr) {
            long snakeNumCount = 0;
            var targetNum = Convert.ToInt64(targetNumStr);

            // 指定の数の桁数以下のへび数を求める
            for (var i = 2; i < targetNumStr.Length; i++) {
                snakeNumCount += _snakeNumbers[i];
            }

            // 先頭の数字
            var n = Convert.ToInt32(targetNumStr[0]);

            if (n == 1) {
                snakeNumCount++;
            } else {
                // 先頭の -1 までの分のへび数を足す
                snakeNumCount += CountSnakeNumber2(n - 1, targetNumStr.Length);

            }

            return snakeNumCount;
        }

        /// <summary>
        ///  へび数かどうか
        /// </summary>
        /// <param name="nstr"></param>
        /// <returns></returns>
        static bool IsSnakeNumber(string nstr) {
            var r = true;
            var c = nstr[0];
            for (var i = 1; i < nstr.Length; i++) {
                if (c <= nstr[i]) {
                    r = false; break;
                }
            }
            return r;
        }

        static Dictionary<string, long> _calcsnakenums = new Dictionary<string, long>();

        static long CountSnakeNumber2(int n, int len) {
            var key = $"{n}_{len}";
            if (_calcsnakenums.ContainsKey(key))  return _calcsnakenums[key];
            long r = 0;
            for (var i = 1; i <= n; i++) {
                r += Pow(i, len - 1);
            }
            _calcsnakenums.Add(key, r);
            return r;
        }

        static Dictionary<string, long> _powers = new Dictionary<string, long>();

        static long Pow(int n, int count) {
            var key = $"{n}_{count}";
            if (_powers.ContainsKey(key)) return _powers[key];

            long result = n;
            for (var i = 1; i < count; i++) {
                result *= n;
            }
            _powers.Add(key, result);
            return result;
        }
    }
}
