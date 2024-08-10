namespace r6_0803_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Leap Year
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc365/tasks/abc365_a</remarks>
        static void Main() {
            var year = Convert.ToInt32(Console.ReadLine());
            var countOfDays = 365;

            if (year % 4 == 0) {
                if (year % 100 != 0) countOfDays = 366;
                else {
                    if (year % 400 == 0) countOfDays = 366;
                }
            }
            Console.WriteLine(countOfDays);
        }
    }
}
