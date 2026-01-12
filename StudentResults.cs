

namespace StudentResults
{
    public static class Results
    {
        static Dictionary<string, int[]> scores = new()
        {
            {"Sophia", new int[]{93,87,98,95,100}},
            {"Nicolas", new int[]{80,83,82,88,85}},
            {"Zachiah", new int[]{84,96,73,85,79}},
            {"Jeong", new int[]{90,92,98,100,97}},
        };

        static Dictionary<string, double> scoresAvg = new();

        public static void CalculateScores()
        {
            foreach (var score in scores)
                GetStudentsAvg(score.Key, score.Value);

            PrintResults();
        }

        public static void PrintTest()
        {
            Console.WriteLine("Hello, World!");
        }

        static char GetGrade(double avg) => avg switch
        {
            >= 90 => 'A',
            >= 80 => 'B',
            >= 70 => 'C',
            >= 60 => 'D',
            >= 50 => 'E',
            _ => 'F'
        };

        static void GetStudentsAvg(string name, int[] studentScores)
        {
            double total = 0;
            foreach (int score in studentScores)
                total += score;

            scoresAvg[name] = total / studentScores.Length;
        }

        static void PrintResults()
        {
            Console.WriteLine("Student scores:");
            foreach (var data in scoresAvg)
                Console.WriteLine($"{data.Key} : {data.Value} {GetGrade(data.Value)}");
        }
    }
}
