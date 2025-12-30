/*"EduQuiz – Student Quiz Grader"
Story: You’re building the grading module for a quiz app. A student answers a 10-question quiz.
You must compare their answers to the correct ones, give feedback, and calculate scores.
Requirements:
● Use two String[] arrays: correctAnswers[] and studentAnswers[].
● Implement a method calculateScore(String[] correct, String[]
student) that returns a score.
● Use string comparison with .equalsIgnoreCase() for case-insensitive matching.
● Print detailed feedback: Question 1: Correct / Incorrect.
● Bonus: Show percentage score and pass/fail message. */

using System;

public class StudentQuizGrader{
    static string[] correctAnswers;
    static string[] studentAnswers;
    static int totalQuestions;
    
//--------------Method To Calculate Scores of the quiz------------//
    public static int calculateScore(string[] correct, string[] student){
        int score = 0;
        for (int i = 0; i < correct.Length; i++){
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase)){
                score++;
            }
        }
        return score;
    }

//-----Method to display the feedback such that the answer is correct or incorrect------//
    public static string CorrectOrIncorrect(string correct, string student){
        if (correct.Equals(student, StringComparison.OrdinalIgnoreCase))
            return "Correct";
        else
            return "Incorrect";
    }


//--------------Method to Calculate Percentage---------------------//  
    public static double calculatePercentage(int score, int totalQuestions){
        return (score * 100.0) / totalQuestions;
    }

//---------------Method to display pass or fail------------//
      public static void passOrFail(double percentage){
            if(percentage>33){
                  Console.WriteLine("Pass");
            }
            else{
                  Console.WriteLine("Fail");
            }
    }

//----------- Teacher Panel--------------------//
    public static void teacherMenu(){
        Console.WriteLine("\n--- Teacher Panel ---");
        Console.Write("Enter total number of questions: ");
        totalQuestions = Convert.ToInt32(Console.ReadLine());

        correctAnswers = new string[totalQuestions];
        studentAnswers = new string[totalQuestions];

        for (int i = 0; i < totalQuestions; i++){
            Console.Write($"Enter correct answer for question {i + 1}: ");
            correctAnswers[i] = Console.ReadLine();
        }
    }

    
//---------------student panel--------------------//
    public static void studentMenu(){
        Console.WriteLine("\n--- Student Panel ---");
        for (int i = 0; i < correctAnswers.Length; i++){
            Console.Write($"Enter student answer for question {i + 1}: ");
            studentAnswers[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Quiz Feedback ---");
        for (int i = 0; i < studentAnswers.Length; i++){
            Console.WriteLine($"Question {i + 1}: {CorrectOrIncorrect(correctAnswers[i], studentAnswers[i])}");
        }

        int score = calculateScore(correctAnswers, studentAnswers);
        double percentage = calculatePercentage(score, totalQuestions);

        Console.WriteLine($"\nTotal Score: {score}/{totalQuestions}");
        Console.WriteLine($"Percentage: {percentage}%");
        passOrFail(percentage);    
    }

//-------------------Main method----------------------------//    
    public static void Main(string[] args){
        while (true){
            Console.WriteLine("\n=== EDUQUIZ - Student Quiz Grader ===");
            Console.WriteLine("1. Teacher");
            Console.WriteLine("2. Student");
            Console.WriteLine("3. Exit");
            Console.Write("Choose role: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    teacherMenu();
                    break;
                case 2:
                    studentMenu();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
