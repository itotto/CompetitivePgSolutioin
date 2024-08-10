using System.Collections.Generic;

namespace r6_0810_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Election 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc366/tasks/abc366_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var validVotes = Convert.ToInt32(inputs[0]);
            var votesForTakahashi = Convert.ToInt32(inputs[1]);
            var votesForAoki = Convert.ToInt32(inputs[2]);

            var limitVotes = validVotes / 2;
            if (limitVotes < votesForTakahashi || limitVotes < votesForAoki) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
