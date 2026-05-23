using System.Text;

namespace r8_0523_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Hell, World! 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc459/tasks/abc459_a</remarks>
        static void Main() {
            const string BASESTR = "HelloWorld";
            var x = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();
            for (var i = 0; i < BASESTR.Length; i++) {
                if (i + 1 != x) result.Append(BASESTR[i]);
            }
            Console.WriteLine(result);

        }
    }
}
