namespace r8_0718_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Obesity 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc467/tasks/abc467_a</remarks>
        static void Main() {
            var condition = Console.ReadLine()?.Split(' ');
            if (condition == null) return;
            var height = Convert.ToInt32(condition[0]);
            var weight = Convert.ToInt32(condition[1]);

            var bmi = weight * 10000.0 / (height * height);
            Console.WriteLine(bmi >= 25.0 ? "Yes" : "No");
        }
    }
}
