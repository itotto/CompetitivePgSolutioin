using System.Text;

namespace r7_0315_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Ticket Gate Log
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var sb = new StringBuilder(s);
            var cnt = 0;
            var start = 0;

            while (true) {
                var isMatched = true;
                for (var i = start; i < sb.Length; i++) {
                    var targetChar = i % 2 == 0 ? 'i' : 'o'; // index と 文字目は1ずれる
                    if (sb[i] != targetChar) {
                        sb.Insert(i, targetChar);
                        cnt++;
                        start = i;
                        isMatched = false;
                    }
                }
                if (isMatched) {
                    if (sb.Length % 2 == 1) cnt++;
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
