using System.Collections.Generic;

namespace r7_0322_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Full House 3
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc398/tasks/abc398_b</remarks>
        static void Main() {
            var cardsInfo = Console.ReadLine()?.Split(' ');
            if (cardsInfo == null) return;

            var cards = new Dictionary<int, int>();
            foreach (var ci in cardsInfo) {
                var c = Convert.ToInt32(ci);
                if (cards.ContainsKey(c)) cards[c]++;
                else cards[c] = 1;
            }

            var twoPairsExists = false;
            var threePairsExists = false;
            var cardsCount_OrderByAsc = cards.Values.ToList();
            cardsCount_OrderByAsc.Sort();
            foreach (var count in cardsCount_OrderByAsc) {
                if (count == 2) twoPairsExists = true;
                if (count == 3 || count == 4 || count == 5) {
                    if (!threePairsExists) threePairsExists = true;
                    else {
                        if (!twoPairsExists) twoPairsExists = true;
                    }
                }
                continue;
            }

            Console.WriteLine(twoPairsExists && threePairsExists ? "Yes" : "No");
        }
    }
}
