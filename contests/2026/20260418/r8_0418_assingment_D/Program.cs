using System.Text;

namespace r8_0418_assingment_D {
    internal class Program {
        /// <summary>
        /// D - (xx)
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc454/tasks/abc454_d</remarks>
        static void Main() {
            var testCount = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();
            for (var i = 0; i < testCount; i++) {
                var ts1 = Console.ReadLine();
                var ts2 = Console.ReadLine();
                if (string.IsNullOrEmpty(ts1) || string.IsNullOrEmpty(ts2)) continue;

                var s_ts1 = GetShorterString(ts1);
                if (s_ts1.Length > ts2.Length) result.AppendLine("No");
                else {
                    var s_ts2 = GetShorterString(ts2);
                    result.AppendLine($"{(s_ts1 == s_ts2 ? "Yes" : "No")}");
                }
            }
            Console.WriteLine(result.ToString());
        }

        static string GetShorterString(string s) {
            const string TARGETSTR = "(xx)";
            const string REPLACETSTR = "xx";
            var originalStr = s;
            while (true) {
                var replacedStr = originalStr.Replace(TARGETSTR, REPLACETSTR);
                if (originalStr.Length == replacedStr.Length) {
                    return replacedStr;
                }
                originalStr = replacedStr;
            }
        }
    }
}
