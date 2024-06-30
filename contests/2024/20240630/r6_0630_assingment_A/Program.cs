using System.Diagnostics.CodeAnalysis;

namespace r6_0630_assingment_A {
    internal class Program {
        /// <summary>
        /// A - A Healthy Breakfast
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc360/tasks/abc360_a</remarks>
        static void Main() {
            var menu = Console.ReadLine();
            if (string.IsNullOrEmpty(menu)) return;
            Console.WriteLine(menu.IndexOf('R') < menu.IndexOf('M') ? "Yes" : "No");
        }
    }
}
