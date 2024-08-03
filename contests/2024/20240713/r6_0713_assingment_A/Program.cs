using System.Collections.Generic;

namespace r6_0713_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Buy a Pen
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc362/tasks/abc362_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var priceOfRed = Convert.ToInt32(conditions[0]);
            var priceOfGreen = Convert.ToInt32(conditions[1]);
            var priceOfBlue = Convert.ToInt32(conditions[2]);

            var dislikeColor = Console.ReadLine();
            if (string.IsNullOrEmpty(dislikeColor)) return;

            var min = -1;
            switch (dislikeColor) {
                case "Red":
                    min = priceOfBlue >= priceOfGreen ? priceOfGreen : priceOfBlue;
                    break;

                case "Green":
                    min = priceOfRed >= priceOfBlue ? priceOfBlue : priceOfRed;
                    break;

                case "Blue":
                    min = priceOfRed >= priceOfGreen ? priceOfGreen : priceOfRed;
                    break;
            }
            Console.WriteLine(min);
        }
    }
}
