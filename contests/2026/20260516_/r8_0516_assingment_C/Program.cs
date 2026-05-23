namespace r8_0516_assingment_C {
    internal class Program {
        /// <summary>
        /// C - C Stands for Center
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc458/tasks/abc458_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            long count = 0;

            if (s.Length == 1) {
                count = s[0] == 'C' ? 1 : 0;
            } else {
                for (var i = 0; i < s.Length; i++) {
                    if (s[i] != 'C') continue;

                    var cnt = i;
                    var leftCnt = s.Length - i - 1;
                    if (cnt > leftCnt) cnt = leftCnt;
                    count += cnt + 1; // +1 は1文字(Cのみ)も含むため
                }
            }
            Console.WriteLine(count);
        }
    }
}
