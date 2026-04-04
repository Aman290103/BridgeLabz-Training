using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.EduResults___Rank_Sheet_Generator__Merge_Sort_
{
	public class RankSorterUtility
	{
		public static class RankSortUtility
		{
			public static List<Student> SortByScore(List<Student> students)
			{
				if (students.Count <= 1)
					return students;

				int mid = students.Count / 2;

				var left = SortByScore(students.GetRange(0, mid));
				var right = SortByScore(students.GetRange(mid, students.Count - mid));

				return Merge(left, right);
			}

			private static List<Student> Merge(List<Student> left, List<Student> right)
			{
				var result = new List<Student>();
				int i = 0, j = 0;

				while (i < left.Count && j < right.Count)
				{
					if (left[i].Score >= right[j].Score) // Descending
					{
						result.Add(left[i]);
						i++;
					}
					else
					{
						result.Add(right[j]);
						j++;
					}
				}

				result.AddRange(left.GetRange(i, left.Count - i));
				result.AddRange(right.GetRange(j, right.Count - j));

				return result;
			}
		}
	}
}


