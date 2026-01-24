using System.Collections.Generic;

namespace _15_To3 {
    internal class Program {
        /// <summary>
        /// C - To 3
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc182/tasks/abc182_c</remarks>
        static void Main() {
            var n = Console.ReadLine();
            var minLength = n.Length;
            if (string.IsNullOrEmpty(n)) return;

            // 全部のけたを足す+3で割った余りを分類する
            var surpluses = new Dictionary<int, int>();
            var sum = 0;
            foreach (var c in n) {
                var x = int.Parse(c.ToString()) % 3;
                if (surpluses.ContainsKey(x)) surpluses[x]++;
                else surpluses[x] = 1;
                sum += x;
            }

            var result = -1;
            var s = sum % 3;
            if (s == 0) {
                result = 0;
            } else {
                if (minLength >= 2) {
                    // 全体の余りと同じ余りの項目がある場合は 1 消せばOK
                    if (surpluses.ContainsKey(s)) {
                        result = 1;
                    } else {
                        // 余りが1の場合は2が2つ以上あればいい
                        if (s == 1) {
                            if (surpluses.TryGetValue(2, out var v)) {
                                if (v != minLength && v >= 2) result = 2;
                            }

                            // 余りが2の場合は1が2つ以上あればいい
                        } else if (s == 2) {
                            if (surpluses.TryGetValue(1, out var v)) {
                                if (v != minLength && v >= 2) result = 2;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
