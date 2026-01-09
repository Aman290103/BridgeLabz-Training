using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.FitTrack__Fitness_Tracker
{
    public interface ITrackable
    {
        double calculateCaloriesBurned();

        void displayWorkoutInfo();
	}
}
