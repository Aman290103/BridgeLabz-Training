using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public class StrengthWorkout : Workout
    {
        public int sets { get; set; }
        public int repsPerSet { get; set; }
        public double weightInKg { get; set; }
        public StrengthWorkout(string name, int durationInMinutes, int sets, int repsPerSet, double weightInKg)
            : base(name, durationInMinutes)
        {
            this.sets = sets;
            this.repsPerSet = repsPerSet;
            this.weightInKg = weightInKg;
        }

        public override double calculateCaloriesBurned()
        {
            // Simple formula: Calories burned = sets * repsPerSet * weight (kg) * 0.1
            return sets * repsPerSet * weightInKg * 0.1;
		}
        public override void displayWorkoutInfo()
        {
            base.displayWorkoutInfo();
            Console.WriteLine($"Sets: {sets}, Reps per Set: {repsPerSet}, Weight: {weightInKg} kg");
		}
	}
}
