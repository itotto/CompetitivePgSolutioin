namespace r6_0427_assingment_A {
    internal class Program {
        static void Main() {

            var tScore = 0;
            var takahashiScores = Console.ReadLine()?.Split(' ');
            if (takahashiScores == null) return;
            for (var i = 0; i < takahashiScores.Length; i++) {
                tScore += Convert.ToInt32(takahashiScores[i]);
            }

            var aScore = 0;
            var aokiScores = Console.ReadLine()?.Split(' ');
            if (aokiScores == null) return;
            for (var i = 0; i < aokiScores.Length; i++) {
                aScore += Convert.ToInt32(aokiScores[i]);
            }

            Console.WriteLine(tScore - aScore + 1);
        }
    }
}
