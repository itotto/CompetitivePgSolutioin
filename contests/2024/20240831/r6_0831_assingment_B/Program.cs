using System.Collections.Generic;

namespace r6_0831_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Piano 3
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc369/tasks/abc369_b</remarks>
        static void Main() {
            var countOfStrokes = Convert.ToInt32(Console.ReadLine());

            var leftPos = -1;
            var rightPos =-1;

            var exhaustion = 0;

            for (var i = 0; i < countOfStrokes ; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var nextPos = Convert.ToInt32(conditions[0]);
                if (conditions[1] == "L") {
                    if (leftPos == -1 || leftPos == nextPos) {
                        leftPos = nextPos;
                    } else {
                        exhaustion += leftPos > nextPos ? leftPos - nextPos : nextPos - leftPos;
                        leftPos = nextPos;
                    }
                } else if (conditions[1] == "R") {
                    if (rightPos == -1 || rightPos == nextPos) {
                        rightPos = nextPos;
                    } else {
                        exhaustion += rightPos > nextPos ? rightPos - nextPos : nextPos - rightPos;
                        rightPos = nextPos;
                    }
                }
            }

            Console.WriteLine(exhaustion);
        }
    }
}
