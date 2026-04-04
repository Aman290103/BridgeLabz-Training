using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.EduResults___Rank_Sheet_Generator__Merge_Sort_
{
    public class Student 
    {
        public string Name { get; set; }    
        public int Score { get; set; }

        public Student(string name, int score) 
        {
            this.Name = name;
            this.Score = score;
		}

        public override string ToString()
        {
            return $"{Name} -> {Score}";
        }
	}
}
