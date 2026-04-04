using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa_scenario.ParcelTracker___Delivery_Chain_Management
{
		public class ParcelTrackerUtility : IParcelTracker
		{
			private ParcelStage head;

			public ParcelTrackerUtility()
			{
				head = null;
			}

			public void AddStage(string stageName)
			{
				ParcelStage newStage = new ParcelStage(stageName);

				if (head == null)
				{
					head = newStage;
					return;
				}

				ParcelStage current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}

				current.Next = newStage;
			}

			public void AddCheckpointAfter(string existingStage, string newStage)
			{
				ParcelStage current = head;

				while (current != null && current.StageName != existingStage)
				{
					current = current.Next;
				}

				if (current == null)
				{
					Console.WriteLine($"Stage '{existingStage}' not found.");
					return;
				}

				ParcelStage checkpoint = new ParcelStage(newStage);
				checkpoint.Next = current.Next;
				current.Next = checkpoint;
			}

			public void TrackForward()
			{
				ParcelStage current = head;

				if (current == null)
				{
					Console.WriteLine("No parcel stages available.");
					return;
				}

				Console.WriteLine("Parcel Tracking:");

				while (current != null)
				{
					Console.WriteLine($"→ {current.StageName}");
					current = current.Next;
				}
			}

			public void HandleMissingParcel()
			{
				if (head == null)
				{
					Console.WriteLine("Parcel is missing (null pointer detected).");
				}
				else
				{
					Console.WriteLine("Parcel chain is intact.");
				}
			}
	}
}
