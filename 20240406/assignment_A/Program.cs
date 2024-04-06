using System.Collections.Generic;
using System.Text;

namespace assignment001 {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 1; i <= n; i++) {
                sb.Append(i % 3 == 0 ? "x" : "o");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
