namespace r7_0524_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Security 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc407/tasks/abc407_c</remarks>
        static void Main() {
            const char MINCHAR = '0';

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var addCount = 0;
            // 末尾から処理
            for (var i = s.Length - 1; i >= 0; i--) {
                var c = s[i] - (addCount % 10);
                if (c < MINCHAR) c += 10;
                if (c == MINCHAR) continue;
                addCount += c - MINCHAR;
            }
            Console.WriteLine(addCount + s.Length);
        }
    }
}
