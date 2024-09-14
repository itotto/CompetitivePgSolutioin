using System.Collections.Generic;

namespace r6_0914_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Jiro
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc371/tasks/abc371_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var s_ab = conditions[0];
            var s_ac = conditions[1];
            var s_bc = conditions[2];

            var ageOrder = new char[3] { 'A', 'B', 'C' };

            // A > B
            if (s_ab == ">") {
                // B > C
                if (s_bc == ">") {
                    ageOrder = new char[3]{ 'A', 'B', 'C' };

                // C > B
                } else {
                    ageOrder = s_ac == ">" ? new char[3] { 'A', 'C', 'B' } : new char[3] { 'C', 'A', 'B' };
                }


            // B > A
            } else {
                if (s_ac == ">") {
                    ageOrder = new char[3]{ 'B', 'A', 'C' };
                } else {
                    ageOrder = s_bc == ">" ? new char[3] { 'B', 'C', 'A' } : new char[3] { 'C', 'B', 'A' };
                }
            }
            Console.WriteLine(ageOrder[1]);
        }
    }
}
