using System.Collections.Generic;

namespace r6_0601_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Keys
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc356/tasks/abc356_c</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);
            var k = Convert.ToInt32(cs1[2]);

            var keys = new bool?[n + 1]; // 確保するのは0～n+1で使うのは1～n+1のn
            for (var i = 0; i < keys.Length; i++) { keys[i] = false; }

            // 結果を取得
            for (var i = 0; i < m; i++) {
                var cs2 = Console.ReadLine()?.Split(' ');
                if (cs2 == null) return;
                var c = Convert.ToInt32(cs2[0]);

                // 試行結果
                var r = cs2[cs2.Length - 1] == "o";
                if (r) {
                    // 本数がk本以下なら本物認定
                    if (c <= k) {
                        for (var j = 1; j <= c; j++) { keys[Convert.ToInt32(cs2[j])] = true; }
                    } else {
                        for (var j = 1; j <= c; j++) {
                            var idx = Convert.ToInt32(cs2[j]);
                            if (keys[idx].HasValue && !keys[idx].Value) keys[idx] = null;
                        }
                    }
                } else {
                    for (var j = 1; j <= c; j++) {
                        var idx = Convert.ToInt32(cs2[j]);
                        if (keys[idx].HasValue && keys[idx].Value) keys[idx] = null;
                    }
                }
            }


            var correctcount = 0;
            var possiblecount = 0;
            for (var i = 1; i < keys.Length; i++) {
                if (!keys[i].HasValue) possiblecount++;
                else if (keys[i].Value) correctcount++;
            }

            var result = 0;
            var k_ans = k - correctcount;
            if (possiblecount > k_ans) {
                result = CalcFactorial(possiblecount) / (CalcFactorial(k_ans) * CalcFactorial(possiblecount - k_ans));
            }
            Console.WriteLine(result);
        }

        static Dictionary<int, int> _fact = new Dictionary<int, int>() { { 0, 1 }, { 1, 1 }, { 2, 2 }, { 3, 6 }, { 4, 24 }, { 5, 120 } };

        static int CalcFactorial(int n) {
            if (_fact.ContainsKey(n)) return _fact[n];
            if (!_fact.ContainsKey(n - 1)) {
                _fact.Add(n - 1, CalcFactorial(n - 1));
            }
            return n * _fact[n - 1];
        }
    }
}
