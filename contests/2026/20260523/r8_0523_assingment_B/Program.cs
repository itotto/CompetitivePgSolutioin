using System.Text;

namespace r8_0523_assingment_B {
    internal class Program {
        /// <summary>
        /// B - 459 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc459/tasks/abc459_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();

            var codnitions = Console.ReadLine()?.Split(' ');
            if (codnitions == null) return;
            for (var i = 0; i < codnitions.Length; i++) {
                var c = codnitions[i][0];
                switch (c) {
                    case 'a':
                    case 'b':
                    case 'c':
                        result.Append("2");
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        result.Append("3");
                        break;

                    case 'g':
                    case 'h':
                    case 'i':
                        result.Append("4");
                        break;

                    case 'j':
                    case 'k':
                    case 'l':
                        result.Append("5");
                        break;

                    case 'm':
                    case 'n':
                    case 'o':
                        result.Append("6");
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        result.Append("7");
                        break;

                    case 't':
                    case 'u':
                    case 'v':
                        result.Append("8");
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        result.Append("9");
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
