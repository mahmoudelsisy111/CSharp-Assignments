namespace C_Project
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Mathematics");
            math.Students.Add(new Student("Mahmoud"));
            math.Students.Add(new Student("Habiba"));

            PracticeExam practice = new PracticeExam(60, math, "PracticeExam.txt");
            FinalExam finalExam = new FinalExam(90, math, "FinalExam.txt");

            // Subscribe students to notifications
            foreach (var s in math.Students)
            {
                practice.OnExamStarted += s.ReceiveNotification;
                finalExam.OnExamStarted += s.ReceiveNotification;
            }

            //add questions
            practice.Questions.Add(new TrueFalseQuestion("TF1", "C# is managed Code?", 5));
            practice.CorrectAnswers.Add(practice.Questions[0], practice.Questions[0].Answers[0]); // True

            practice.Questions.Add(new ChooseOneQuestion("CO1", "Select even number", 5, new List<string> { "1", "6", "3" }));
            practice.CorrectAnswers.Add(practice.Questions[1], practice.Questions[1].Answers[1]); // 6

            finalExam.Questions.Add(new ChooseAllQuestion("CA1", "Select even numbers", 5, new List<string> { "1", "2", "3", "4" }));

            Console.WriteLine("Select Exam Type: 1 - Practice, 2 - Final");
            string choice = Console.ReadLine();

            if (choice == "1")
                practice.ShowExam();
            else
                finalExam.ShowExam();

        }
    }
}
