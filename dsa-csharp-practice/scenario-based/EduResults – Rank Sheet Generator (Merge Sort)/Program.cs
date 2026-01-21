using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dsa_scenario.EduResults___Rank_Sheet_Generator__Merge_Sort_.RankSorterUtility;

namespace Dsa_scenario.EduResults___Rank_Sheet_Generator__Merge_Sort_
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var district1 = new List<Student>
		{
			new Student("A", 95),
			new Student("B", 90),
			new Student("C", 85)
		};

			var district2 = new List<Student>
		{
			new Student("D", 96),
			new Student("E", 90),
			new Student("F", 80)
		};

			var allStudents = new List<Student>();
			allStudents.AddRange(district1);
			allStudents.AddRange(district2);

			var finalRankList = RankSortUtility.SortByScore(allStudents);

			Console.WriteLine("State-Wise Rank List:");
			foreach (var student in finalRankList)
			{
				Console.WriteLine(student);
			}
		}

	}
}
