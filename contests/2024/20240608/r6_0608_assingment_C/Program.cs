using System.Collections.Generic;

namespace r6_0608_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sierpinski carpet 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc357/tasks/abc357_c</remarks>
        static void Main() {
            var k = Convert.ToInt32(Console.ReadLine());
        }

        static char[,] Print(int level, bool isCenter) {
            var r = new char[level, level];
            if (isCenter) {
                for (var i = 0; i < level; i++) {
                    for (var j = 0; j < level; j++) { r[i, j] = '.'; }
                }
            } else if (level == 1) {
                r[0, 0] = '#';
            } else {
                for (var i = 0; i < level; i++) {
                    for (var j = 0; j < level; j++) {
                        r[i, j] = '.';
                    }
                }
            }
            return r;
        }
    }
}
