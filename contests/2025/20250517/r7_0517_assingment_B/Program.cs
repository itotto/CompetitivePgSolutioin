
namespace r7_0517_assingment_B {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var k = Convert.ToInt32(conditions1[1]);

            ulong limit = 10;
            for (var i = 1; i < k; i++) {
                limit *= 10;
            }
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            ulong result = 1;
            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToUInt64(conditions2[i]);

                if (a_i.ToString().Length + result.ToString().Length > k + 2) {
                    result = 1;
                } else {
                    result = a_i * result;
                    if (result >= limit) result = 1;
                }

            }
            Console.WriteLine(result);
        }
    }
}