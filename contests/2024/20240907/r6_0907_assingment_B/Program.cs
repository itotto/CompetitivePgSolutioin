using System.Collections.Generic;

namespace r6_0907_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Binary Alchemy
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc370/tasks/abc370_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var converter = new Dictionary<string, int>(n * n);

            // 変換テーブルの初期化
            for (var i = 1; i <= n; i++) {
                var convertdata = Console.ReadLine()?.Split(' ');
                if (convertdata == null) return;
                for (var j = 1; j <= convertdata.Length; j++) {
                    var data = Convert.ToInt32(convertdata[j - 1]);
                    converter.Add($"{i}-{j}", data);
                    if (i != j) {
                        converter.Add($"{j}-{i}", data);
                    }
                }
            }

            var alchemy = 1;
            for (var i = 1; i <= n; i++) {
                alchemy = converter[$"{alchemy}-{i}"];
            }

            Console.WriteLine(alchemy);
        }
    }
}
