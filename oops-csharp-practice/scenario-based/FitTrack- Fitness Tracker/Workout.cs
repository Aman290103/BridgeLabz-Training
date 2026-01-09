using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public abstract class Workout : ITrackable
	{
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Workout(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
		}
        public abstract double calculateCaloriesBurned();

        public virtual void displayWorkoutInfo()
        {
            Console.WriteLine($"Workout: {Name}, Duration: {DurationInMinutes} minutes, Calories Burned : {calculateCaloriesBurned()}" );
		}

	}
}
