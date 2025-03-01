namespace r7_0222_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Debug
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc394/tasks/abc394_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var s_chars = s.ToCharArray();

            for (var i = 0; i < s.Length - 1; i++) {
                if (s_chars[i] == 'W' && s_chars[i + 1] == 'A') {
                    s_chars[i] = 'A';
                    s_chars[i + 1] = 'C';
                }
            }

            var pos = 0;
            while (pos < s.Length - 1) {
                if (s_chars[pos] == 'W' && s_chars[pos + 1] == 'A') {
                    s_chars[pos] = 'A';
                    s_chars[pos + 1] = 'C';
                    if (pos > 0) pos--;
                } else {
                    if (s_chars[pos++ + 1] != 'W') pos++;
                }
            }

            Console.WriteLine(new string(s_chars));
        }
    }
}
