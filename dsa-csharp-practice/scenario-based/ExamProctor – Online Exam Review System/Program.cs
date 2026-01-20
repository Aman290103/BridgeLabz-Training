using System;
using System.Collections.Generic;

namespace Dsa_scenario.ExamProctor___Online_Exam_Review_System
{
	public class Program
	{
		static void Main()
		{
			// Correct answers
			var correctAnswers = new Dictionary<int, string>
			{
				{1, "A"},
				{2, "B"},
				{3, "C"}
			};

			// Start exam session
			StudentScore session = new StudentScore(correctAnswers);

			// Navigation + Answers
			session.visitQuestion(1);
			session.submitAnswer(1, "A");

			session.visitQuestion(2);
			session.submitAnswer(2, "B");

			session.visitQuestion(3);
			session.submitAnswer(3, "D"); // Wrong answer

			// Calculate score
			int score = session.CalculateScore();

			Console.WriteLine("\nFinal Score: " + score + "/3");
		}
	}
}
