﻿using System.Collections.Generic;

namespace r6_0608_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Uppercase and Lowercase
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc357/tasks/abc357_b</remarks>
        static void Main() {
            var upperChars = new Dictionary<char, byte> {
                {'A',1 }, {'B',1 }, {'C',1 }, {'D',1 }, {'E',1 }, {'F',1 }, {'G',1 }, {'H',1 },
                {'I',1 }, {'J',1 }, {'K',1 }, {'L',1 }, {'M',1 }, {'N',1 }, {'O',1 }, {'P',1 },
                {'Q',1 }, {'R',1 }, {'S',1 }, {'T',1 }, {'U',1 }, {'V',1 }, {'W',1 }, {'X',1 },
                {'Y',1 }, {'Z',1 },
            };

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var baseCnt = s.Length;
            var upperCaseCnt = 0;

            foreach (var c in s) {
                if (upperChars.ContainsKey(c)) upperCaseCnt++;
            }
            Console.WriteLine(baseCnt - upperCaseCnt > upperCaseCnt ? s.ToLower() : s.ToUpper());
        }
    }
}
