using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public class UserProfile
    {
        public string UserName { get; set; }
        public int Age { get; set; }

        public Workout[] Workouts { get; set; }

		public UserProfile(string userName, int age, int maxWorkouts)
		{
			UserName = userName;
			Age = age;
			Workouts = new Workout[maxWorkouts];
		}
		public void AddWorkout(Workout workout)
		{
			for (int i = 0; i < Workouts.Length; i++)
			{
				if (Workouts[i] == null)
				{
					Workouts[i] = workout;
					return;
				}
			}
			Console.WriteLine("Workout list is full!");
		}
		public void DisplayProfile()
		{
			Console.WriteLine($"User: {UserName}, Age: {Age}");
			Console.WriteLine("Workouts:");
			foreach (var workout in Workouts)
			{
				if (workout != null)
				{
					workout.displayWorkoutInfo();
					Console.WriteLine();
				}
			}
		}

	}
}
