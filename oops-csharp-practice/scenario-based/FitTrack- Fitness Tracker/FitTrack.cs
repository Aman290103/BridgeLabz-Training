using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public class FitTrack
    {
		public static void Main(string[] args)
		{
			UserProfile user = new UserProfile("Aman", 24, 5);
			Workout cardio = new CardioWorkout("Morning Run", 30, 5);
			Workout strength = new StrengthWorkout("Weight Lifting", 45, 4, 10, 50);
			user.AddWorkout(cardio);
			user.AddWorkout(strength);
			user.DisplayProfile();
		}
	}

}

