using System.Text;

namespace r8_0516_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Count Adjacent Cells
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc458/tasks/abc458_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var h = Convert.ToInt32(conditions[0]);
            var w = Convert.ToInt32(conditions[1]);

            var result = new StringBuilder();

            for (var i = 1; i <= h; i++) {
                for (var j = 1; j <= w; j++) {
                    var count = 4;
                    if (i == 1 || i == h) count--;
                    if (j == 1 || j == w) count--;
                    if (h == 1) count--;
                    if (w == 1) count--;
                    result.Append($"{count} ");
                }
                result.Remove(result.Length - 1, 1);
                result.AppendLine();
            }
            Console.WriteLine(result);
        }
    }
}
