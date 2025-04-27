namespace r7_0427_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Four Hidden 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc403/tasks/abc403_b</remarks>
        static void Main() {
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(t)) return;

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var isFound = false;
            for (var i = 0; i <= t.Length - s.Length; i++) {
                var isMatched = true;
                for (var j = 0; j < s.Length; j++) {
                    if (t[i + j] == '?') continue;
                    if (t[i + j] == s[j]) continue;
                    isMatched = false;
                    break;
                }
                if (isMatched) {
                    isFound = true;
                    break;
                }
            }
            Console.WriteLine(isFound ? "Yes" : "No");
        }
    }
}
