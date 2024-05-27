using System.Collections.Generic;

namespace r6_0413_assignment_E {
    internal class Program {
        /// <summary>
        /// E - Weighted Tic-Tac-Toe
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc349/tasks/abc349_e</remarks>
        static void Main() {
            const byte SQUARE_SIZE = 3;

            // マス目
            var squares = new int[SQUARE_SIZE, SQUARE_SIZE];
            for (int j = 0; j < SQUARE_SIZE; j++) {
                var data = Console.ReadLine()?.Split(' ');
                if (data == null) return;
                squares[0, j] = Convert.ToInt32(data[0]);
                squares[1, j] = Convert.ToInt32(data[1]);
                squares[2, j] = Convert.ToInt32(data[2]);
            }

            // 
            var squaresStatus = new bool[SQUARE_SIZE, SQUARE_SIZE];
            for (int j = 0; j < SQUARE_SIZE; j++) {
                for (int i = 0; i < SQUARE_SIZE; i++) {
                    squaresStatus[i, j] = true;
                }
            }

            long point_t = 0; //高橋くんのポイント
            long point_a = 0; //青木くんのポイント

            // 高橋くん(1手目)
            squaresStatus[1, 1] = false;
            point_t += squares[1, 1];

            // 青木くん(1手目)



            Console.WriteLine(point_t > point_a ? "Takahashi" : "Aoki");
        }
    }
}
