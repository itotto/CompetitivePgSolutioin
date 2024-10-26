using System.Collections.Generic;

namespace r6_1026_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Avoid Rook Attack
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc377/tasks/abc377_b</remarks>
        static void Main() {
            const int CELL_COUNT = 8;
            var cells = new char[CELL_COUNT, CELL_COUNT];

            var rowNumbers = new Dictionary<int, bool>();
            var columnNumbers = new Dictionary<int, bool>();

            // 入力
            for (var i = 0; i < CELL_COUNT; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) throw new ArgumentException("bad data.");
                for (var j = 0; j < CELL_COUNT; j++) {
                    var cell = line[j];
                    if (cell == '#') {
                        if (!rowNumbers.ContainsKey(i)) rowNumbers.Add(i, true);
                        if (!columnNumbers.ContainsKey(j)) columnNumbers.Add(j, true);
                    }
                    cells[i, j] = cell;
                }
            }

            for (var i = 0; i < CELL_COUNT; i++) {
                var isAffected = rowNumbers.ContainsKey(i);
                for (var j = 0; j < CELL_COUNT; j++) {
                    if (isAffected) cells[i, j] = '#';
                    else {
                        if (columnNumbers.ContainsKey(j)) cells[i, j] = '#';
                    }
                }
            }

            var cnt = 0;
            for (var i = 0; i < CELL_COUNT; i++) {
                for (var j = 0; j < CELL_COUNT; j++) {
                    if (cells[i, j] == '.') cnt++;
                }
            }
            Console.WriteLine(cnt);

            //// debug
            //Console.WriteLine("-----------------------------------------------");
            //for (var i = 0; i < CELL_COUNT; i++) {
            //    for (var j = 0; j < CELL_COUNT; j++) {
            //        Console.Write(cells[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();
        }
    }
}
