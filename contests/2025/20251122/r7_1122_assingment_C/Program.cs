namespace r7_1122_assingment_C {
    internal class Program {
        /// <summary>
        /// C - 1122 Substring 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc433/tasks/abc433_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var count = 0;

            // 場所
            var pos = 1;
            var minPos = 0;
            var maxPos = s.Length - 1;

            var lastChar = s[0]; // 1文字目を入れておく

            while (true) {
                // 最後までいったらおしまい
                if (pos >= s.Length - 1) break;

                var currentChar = s[pos];

                // 同じだったらとりあえず次へ
                if (currentChar == lastChar) {
                    pos++;
                    continue;
                }

                if (lastChar + 1 != currentChar) {
                    lastChar = currentChar;
                    pos++;
                    continue;
                }

                // ここまできたら 12 を満たすので +1
                var workCount = 1;

                while (true) {
                    var left = pos - workCount - 1;
                    if (left < minPos) break;
                    var right = pos + workCount;
                    if (right > maxPos) break;

                    if (s[left] == lastChar && s[right] == currentChar) workCount++;
                    else break;
                }

                lastChar = currentChar;
                minPos = pos;
                //pos += workCount - 1;
                count += workCount;
            }
            Console.WriteLine(count);
        }
    }
}
