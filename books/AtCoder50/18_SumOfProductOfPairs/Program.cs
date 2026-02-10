using System.Collections.Generic;

namespace _18_SumOfProductOfPairs {
    internal class Program {
        /// <summary>
        /// C - Sum of product of pairs
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc177/tasks/abc177_c</remarks>
        static void Main() {
            const long BASENUMBER = 1000000007;
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new int[n];
            long sumAll = 0;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < conditions.Length; i++) {
                data[i] = Convert.ToInt32(conditions[i]);
                sumAll += data[i];
                if (sumAll > BASENUMBER) sumAll %= BASENUMBER;
            }

            long timesSum = 0;
            for (var i = 0; i < n - 1; i++) {
                sumAll -= data[i];
                if (sumAll < 0) sumAll += BASENUMBER;
                timesSum += sumAll * data[i];
                if (timesSum > BASENUMBER) timesSum %= BASENUMBER;
            }
            Console.WriteLine(timesSum);
        }
    }
}
