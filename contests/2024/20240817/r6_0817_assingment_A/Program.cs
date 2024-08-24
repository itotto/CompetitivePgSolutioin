using System.Collections.Generic;

namespace r6_0817_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Shout Everyday
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc367/tasks/abc367_a</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var shoutTime = Convert.ToInt32(cs[0]);
            var startTime = Convert.ToInt32(cs[1]);
            var stopTime = Convert.ToInt32(cs[2]);

            if (stopTime < startTime) {
                stopTime += 24;
                if (shoutTime < startTime) shoutTime += 24;
            }

            Console.WriteLine(startTime < shoutTime && shoutTime < stopTime ? "No" : "Yes");
        }
    }
}
