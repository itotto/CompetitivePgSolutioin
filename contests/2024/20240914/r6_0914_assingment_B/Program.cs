using System.Collections.Generic;
using System.Text;

namespace r6_0914_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Taro
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc371/tasks/abc371_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var countOfHomes = Convert.ToInt32(conditions1[0]);
            var countOfBabies = Convert.ToInt32(conditions1[1]);

            var homeStatus = new Dictionary<int, bool>();
            for (var i = 1; i <= countOfHomes; i++) homeStatus.Add(i, false);

            var result = new StringBuilder();

            for (var i = 0; i < countOfBabies; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var homeId = Convert.ToInt32(conditions2[0]);
                var gender = conditions2[1];

                if (gender == "F") {
                    result.AppendLine("No");
                } else {
                    if (!homeStatus[homeId]) {
                        result.AppendLine("Yes");
                        homeStatus[homeId] = true;
                    } else {
                        result.AppendLine("No");
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
