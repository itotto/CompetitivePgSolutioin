using System.Collections.Generic;

namespace _16_Travel {
    internal class Program {

        /// <summary>
        /// 結果
        /// </summary>
        static Dictionary<int, int> _result = new Dictionary<int, int>();

        /// <summary>
        /// 点と点の距離(key:{from}_{to}, value:distance
        /// </summary>
        static Dictionary<string, int> _distances = new Dictionary<string, int>();

        /// <summary>
        /// デバッグモードかどうか
        /// </summary>
        static bool _isDebug = false;

        /// <summary>
        /// C - Travel
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc183/tasks/abc183_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            for (var i = 1; i <= n; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                for (var j = 1; j <= n; j++) {
                    _distances.Add($"{i}_{j}", Convert.ToInt32(conditions2[j - 1]));
                }
            }

            var data = new List<int>();
            for (var i = 2; i <= n; i++) data.Add(i);
            ToNextStep(1, 0, data);
            Console.WriteLine(_result.ContainsKey(k) ? _result[k] : 0);
        }

        /// <summary>
        /// 次の処理にうつって距離を計算
        /// </summary>
        /// <param name="current"></param>
        /// <param name="sum"></param>
        /// <param name="data"></param>
        static void ToNextStep(int current, int sum, List<int> data) {
            PrintDebugMessage($"{current} - {sum}");
            if (data.Count == 0) {
                sum += _distances[$"{current}_1"];
                if (_result.ContainsKey(sum)) _result[sum]++;
                else _result[sum] = 1;
                PrintDebugMessage($"合計：{sum}\r\n----------");
            } else {
                foreach (var t in data) {
                    var nextList = new List<int>(data);
                    nextList.Remove(t);

                    var key = $"{current}_{t}";
                    PrintDebugMessage($"_distances[{key}] : {_distances[key]}");
                    ToNextStep(t, sum + _distances[key], nextList);
                }
            }
        }

        static void PrintDebugMessage(string msg) {
            if (_isDebug) Console.WriteLine(msg);
        }
    }
}
