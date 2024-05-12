namespace r6_0511_assingment_B {
    internal class Program {
        /// <summary>
        /// B - AtCoder Amusement Park
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc353/tasks/abc353_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            // 入力を数値に変換して保持
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var userGroupCount = new int[n];
            for (var i = 0; i < n; i++) {
                userGroupCount[i] = Convert.ToInt32(inputs[i]);
            }

            var cnt = 0;
            var current = 0; // 順番がきている場所
            while (true) {
                var onBoardingCount = 0;
                // k人に達するまで乗せる
                while (true) {
                    // 今の人数を足して k人を超えるならここでいったん打ち切る
                    if (onBoardingCount + userGroupCount[current] > k) break;

                    // このグループを載せる
                    onBoardingCount += userGroupCount[current++];
                    if (current >= n) break;
                }
                cnt++;

                // 全部載せ終えたら終わる
                if (current >= n) break;
            }

            Console.WriteLine(cnt);
        }
    }
}
