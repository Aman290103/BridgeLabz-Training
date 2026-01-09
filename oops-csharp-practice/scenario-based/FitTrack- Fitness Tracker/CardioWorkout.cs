using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public class CardioWorkout : Workout
    {
        public double distanceInKilometers { get; set; }

        public CardioWorkout(string name, int durationInMinutes, double distanceInKilometers)
            : base(name, durationInMinutes)
        {
            this.distanceInKilometers = distanceInKilometers;
		}
        public override double calculateCaloriesBurned()
        {
            // Simple formula: Calories burned = distance (km) * 60
            return distanceInKilometers * 60;
        }
        public override void displayWorkoutInfo()
        {
            base.displayWorkoutInfo();
            Console.WriteLine($"Distance: {distanceInKilometers} km");
		}   
	}
}
