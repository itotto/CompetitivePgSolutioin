namespace r8_0815_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Nine or Nein
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc471/tasks/abc471_a</remarks>
        static void Main() {
            const int NINE = 9;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);

            var result = a + b == NINE ||
                         a - b == NINE ||
                         a * b == NINE 
                         ? "Nine" : "Nein";

            if (result != "Nine") {
                if (a % b == 0 && a / b == NINE) {
                    result = "Nine";
                }
            }

            Console.WriteLine(result);
        }
    }
}
