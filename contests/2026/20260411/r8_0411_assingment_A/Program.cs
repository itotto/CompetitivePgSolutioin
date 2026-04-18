using System.Text;

namespace r8_0411_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Trimo
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc453/tasks/abc453_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            var result = new StringBuilder();
            var isHead = true;

            foreach (var c in line) {
                if (isHead && c == 'o') continue;
                else {
                    isHead = false;
                    result.Append(c);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
