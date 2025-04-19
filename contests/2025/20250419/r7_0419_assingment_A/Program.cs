using System.Text;

namespace r7_0419_assingment_A {
    internal class Program {
        /// <summary>
        /// A - CBC
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc402/tasks/abc402_a</remarks>
        static void Main() {
            var start = 'A';
            var end = 'Z';

            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            var result = new StringBuilder();
            for (var i = 0; i < line.Length; i++) {
                var c = line[i];
                if (start <= c &&  c <= end) result.Append(c);
            }
            Console.WriteLine(result.ToString());

        }
    }
}
