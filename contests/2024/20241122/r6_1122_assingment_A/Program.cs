namespace r6_1122_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 11/22 String
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc381/tasks/abc381_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var s_len = s.Length;

            var result = false;
            // 奇数
            if (s_len % 2 == 1) {
                var slashPos = (int)((s_len + 1) * 0.5) - 1;

                var checkResult = true;
                // 1文字目から(s_len + 1)/2 - 1までが1
                for (var i = 0; i < slashPos; i++) {
                    if (s[i] != '1') {
                        checkResult = false;
                        break;
                    }
                }

                if (checkResult) {
                    if (s[slashPos] == '/') {
                        for (var i = slashPos + 1; i < s_len; i++) {
                            if (s[i] != '2') {
                                checkResult = false;
                                break;
                            }
                        }
                        if (checkResult) result = true;
                    }
                }
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
