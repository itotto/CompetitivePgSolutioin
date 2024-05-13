using System.Text;

namespace r6_0504_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Typing 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc352/tasks/abc352_b</remarks>
        static void Main() {
            // 先頭1文字目に空文字を入れることで 1文字目から比較できる
            var s = " " + Console.ReadLine();
            var t = " " + Console.ReadLine();

            var r = new StringBuilder();

            var currentPos = 1;
            for (var i = 1; i < s.Length; i++) {
                var targetChar = s[i];
                for (var j = currentPos; j < t.Length; j++) {
                    if (targetChar == t[j]) {
                        r.Append($"{j} ");
                        currentPos = j + 1;
                        break;
                    } else continue;
                }
            }

            // 末尾を削除
            r.Remove(r.Length - 1, 1);
            Console.WriteLine(r.ToString());
        }
    }
}
