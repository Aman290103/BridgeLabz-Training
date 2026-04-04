using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ExamProctor___Online_Exam_Review_System
{
    public class StudentScoreUtility 
    {
		public static int Evaluate(Dictionary<int, string> studentAnswers, Dictionary<int, string> correctAnswers)
		{
            int score = 0;

            foreach (var question in correctAnswers)
            {
                if (studentAnswers.ContainsKey(question.Key) && studentAnswers[question.Key].Equals(question.Value))
                {
                    score++;
                }
            }

            return score;
        }
    }
}
