namespace r6_0427_assingment_B {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // グリッド1 を入力する
            var grid1 = new char[n, n];
            for (var y = 0; y < n; y++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var x = 0; x < n; x++) {
                    grid1[y, x] = line[x];
                }
            }

            var w_y = -1;
            var w_x = -1;

            for (var y = 0; y < n; y++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var x = 0; x < n; x++) {
                    if (grid1[y, x] != line[x]) {
                        w_y = y;
                        w_x = x;
                        break;
                    }
                }
                if (w_y >= 0 || w_x >= 0) break;
            }

            if (w_y >= 0 && w_x >= 0) {
                Console.WriteLine($"{w_y + 1} {w_x + 1}");
            } else throw new Exception("not enough");
        }
    }
}
