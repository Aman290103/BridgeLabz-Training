using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ExamProctor___Online_Exam_Review_System
{
    public class StudentScore : IScore
    {
        private Stack<int> navigationStack;
        private Dictionary<int, string> answers;
        private Dictionary<int, string> correctAnswers; 

        public StudentScore(Dictionary<int, string> correctAnswers)
        {
            navigationStack = new Stack<int>();
            answers= new Dictionary<int, string>();
            this.correctAnswers = correctAnswers;

        }

        //Track Navigation---

        public void visitQuestion(int questionId)
        {
            navigationStack.Push(questionId);
            Console.WriteLine($"Visited Question {questionId}");
        }

        //store answer----

        public void submitAnswer(int questionId, string answer)
        {
            answers[questionId] = answer;
            Console.WriteLine($"Answer saved for Question{questionId}");

        }
		public Dictionary<int, string> GetAnswers()
		{
			return answers;
		}

        public int CalculateScore()
        {
            return StudentScoreUtility.Evaluate(answers, correctAnswers);

		}


	}
}
