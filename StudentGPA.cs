namespace StudentGPA
{
    public static class StudentGPA
    {
      static  double totalScores, totalCreditHours;

      static  Class[] studentScores = { new Class(tname: "English 101", tgrade: 4, tcreditHours: 3), new Class(tname: "Alebra 101", tgrade: 3, tcreditHours: 3), new Class(tname: "Biology 101", tgrade: 3, tcreditHours: 4), new Class(tname: "Computer Science", tgrade: 3, tcreditHours: 4), new Class(tname: "Psycholoy 101", tgrade: 4, tcreditHours: 3) };


        public static void getGPA()
        {
            foreach (Class score in studentScores)
            {
                totalScores += score.creditHours * score.grade;
                totalCreditHours += score.creditHours;
            }

            Console.WriteLine($"GPA value is {totalScores / totalCreditHours}");
        }





    }

    class Class
    {
        public string name;
        public int grade;
        public int creditHours;

        public Class(string tname, int tgrade, int tcreditHours)
        {
            name = tname;
            grade = tgrade;
            creditHours = tcreditHours;

        }
    }



}