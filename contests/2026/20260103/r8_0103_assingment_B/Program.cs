using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace r8_0103_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Happy Number
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var numConverter = new Dictionary<char, int> {
                {'0', 0 }, {'1', 1 }, {'2', 2 }, {'3', 3 }, {'4', 4 },
                {'5', 5 }, {'6', 6 }, {'7', 7 }, {'8', 8 }, {'9', 9 },
            };

            var n = Convert.ToInt32(Console.ReadLine());

            var answers = new Dictionary<int, bool> { { n, true } };
            var result = false;

            var lastNum = n;
            while (true) {
                var sum = 0;
                foreach (var a in lastNum.ToString()) {
                    var w = numConverter[a];
                    sum += w * w;
                }

                if (sum == 1) {
                    result = true;
                    break;
                } else {
                    if (answers.ContainsKey(sum)) break;
                    answers.Add(sum, true);
                    lastNum = sum;
                }
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
