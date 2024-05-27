using System.Collections.Generic;

namespace r6_0518_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Exponential Plant
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc354/tasks/abc354_a</remarks>
        static void Main() {
            var userHeight = Convert.ToInt32(Console.ReadLine());

            var day = 0;
            //if (userHeight == 1) day = 0;
            if (userHeight < 3) day = 2;
            else if (userHeight < 7) day = 3;
            else if (userHeight < 15) day = 4;
            else if (userHeight < 31) day = 5;
            else if (userHeight < 63) day = 6;
            else if (userHeight < 127) day = 7;
            else if (userHeight < 255) day = 8;
            else if (userHeight < 511) day = 9;
            else {
                long totalLen = 511;
                long diff = 256;
                for (day = 10; ; day++) {
                    diff *= 2;
                    totalLen += diff;
                    if (userHeight < totalLen) break;
                }
            }

            Console.WriteLine(day);
        }
    }
}
