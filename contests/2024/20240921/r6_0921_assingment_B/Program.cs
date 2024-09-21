using System.Collections.Generic;

namespace r6_0921_assingment_B {
    internal class Program {
        /// <summary>
        /// B - 3^A
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var expnent3 = new List<int>();
            var basenum = 1;
            for (var i = 0; i <= 10;i++) {
                expnent3.Add(basenum);
                basenum *= 3;
            }

            var m = Convert.ToInt32(Console.ReadLine());

            var answerList = new List<int>();

            var pos = 10;
            while (true) {
                if (expnent3[pos] > m) {
                    pos--;
                } else {
                    m -= expnent3[pos];
                    answerList.Add(pos);
                    if (m == 0) break;
                }
            }

            // N
            Console.WriteLine(answerList.Count);

            // A_i
            answerList.Sort((x,y) => x - y);
            Console.Write(answerList[0]);
            for (var i = 1; i <= answerList.Count - 1; i++) Console.Write($" {answerList[i]}");
            Console.WriteLine();
        }
    }
}
