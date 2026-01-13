
using System.Text;

namespace _9_Unlucky7 {
    internal class Program {
        /// <summary>
        /// C - Unlucky 7
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc186/tasks/abc186_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var countOf7 = 0;
            for (var i = 1; i <= n; i++) {
                // debug
                // Console.WriteLine($"{i}\t{ConvertToNthStr(i, baseNumber:8)}");
                if (i.ToString().IndexOf("7") >= 0) {
                    countOf7++;
                } else {
                    if (IsContainNumberAtOctStr(i)) countOf7++;
                }
            }
            Console.WriteLine(n - countOf7);
        }

        static bool IsContainNumberAtOctStr(int hex) {
            const int BASENUMBER = 8;

            while (hex != 0) {
                if (hex % BASENUMBER == 7) return true;
                hex /= BASENUMBER;
            }
            return false;
        }

        static string ConvertToNthStr(int n, int baseNumber = 8) {
            if (n == 0) return "0";
            var result = new StringBuilder();
            while (n != 0) {
                result.Append($"{(n % baseNumber)}");
                n /= baseNumber;
            }
            return new string([.. result.ToString().Reverse()]);
        }
    }
}
