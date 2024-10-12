namespace r6_1005_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Unvarnished Report 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc374/tasks/abc374_b</remarks>
        static void Main() {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;

            var maxLen = s.Length > t.Length ? s.Length : t.Length;
            s = s.PadRight(maxLen, '*');
            t = t.PadRight(maxLen, '*');
            var pos = 0;
            if (s != t) {
                for (var i = 0; i < maxLen; i++) {
                    if (s[i] == t[i]) continue;
                    pos = i + 1;
                    break;
                }
            }
            Console.WriteLine(pos);
        }
    }
}
