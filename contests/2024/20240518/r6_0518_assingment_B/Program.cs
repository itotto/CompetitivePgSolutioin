using System.Collections.Generic;

namespace r6_0518_assingment_B {
    internal class Program {
        /// <summary>
        /// B - AtCoder Janken 2 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc354/tasks/abc354_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            var users = new List<string>();
            for (var i = 0; i < n; i++) {
                var inputs = Console.ReadLine()?.Split(' ');
                if (inputs == null) return;
                users.Add(inputs[0]);
                sum += Convert.ToInt32(inputs[1]);
            }

            var pos = sum % n;

            // 並び替え
            users.Sort((u1, u2) => u1.CompareTo(u2));

            Console.WriteLine(users[pos]);
        }
    }
}
