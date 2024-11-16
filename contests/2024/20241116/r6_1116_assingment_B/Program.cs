namespace r6_1116_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Hurdle Parsing
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc380/tasks/abc380_b</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;
            var convertedLine = line.Remove(line.Length - 1, 1).Remove(0, 1);

            // TODO:remove
            //Console.WriteLine(convertedLine);

            var splittedLine = convertedLine.Split('|');
            Console.Write(splittedLine[0].Length);
            for (var i = 1; i < splittedLine.Length; i++) {
                Console.Write($" {splittedLine[i].Length}");
            }
            Console.WriteLine();
        }
    }
}
