using System.Collections.Generic;

namespace r7_0412_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Unauthorized
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc401/tasks/abc401_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var isLoggedin = false;
            var errorCount = 0;
            for (var i = 0; i < n; i++) {
                var order = Console.ReadLine();
                if (string.IsNullOrEmpty(order)) continue;

                switch (order) {
                    case "login":
                        isLoggedin = true;
                        break;
                    case "logout":
                        isLoggedin = false;
                        break;
                    case "public":
                        break;
                    case "private":
                        if (!isLoggedin) errorCount++;
                        break;
                }
            }
            Console.WriteLine(errorCount);

        }
    }
}
