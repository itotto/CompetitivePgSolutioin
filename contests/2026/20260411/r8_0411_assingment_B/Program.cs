using System.Text;

namespace r8_0411_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Sensor Data Logging 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc453/tasks/abc453_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var t = Convert.ToInt32(conditions1[0]);
            var x = Convert.ToInt32(conditions1[1]);

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            var lastValue = Convert.ToInt32(conditions2[0]);
            var result = new StringBuilder();
            result.AppendLine($"0 {lastValue}");

            for (var i = 1; i < conditions2.Length; i++) {
                var currentValue = Convert.ToInt32(conditions2[i]);
                var diff = Math.Abs(currentValue - lastValue);
                if (diff < x) continue;

                result.AppendLine($"{i} {currentValue}");
                lastValue = currentValue;
            }
            if (result.Length == 0) Console.WriteLine();
            else Console.Write(result.ToString());
        }
    }
}
