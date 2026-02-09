using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StreamBuzz
{
    public class Program
    {
        CreatorStats creator = new CreatorStats();
        public void RegisterCreator(CreatorStats record) 
        {
            CreatorStats.EngagementBoard.Add(record);
        }

		public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold) 
        {
            Dictionary<string,int> result = new Dictionary<string,int>();

            foreach (CreatorStats record in records) 
            {
                int count = creator.WeeklyLikes.Count(like => like >= likeThreshold);
                if (count > 0)
                {
                    result[creator.CreatorName] = count;
                }

            }
            return result;
        }

		public double CalculateAverageLikes() 
        {
			double totalLikes = 0;
			int totalWeeks = 0;

			foreach (CreatorStats creator in CreatorStats.EngagementBoard)
			{
				foreach (double likes in creator.WeeklyLikes)
				{
					totalLikes += likes;
					totalWeeks++;
				}
			}

			if (totalWeeks == 0)
				return 0;

			return totalLikes / totalWeeks;
		}

        public static void Main(string[] args) 
        {
            Program program = new Program();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter Your Choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreatorStats creator = new CreatorStats();

                        Console.WriteLine("Enter Creator Name");
                        creator.CreatorName = Console.ReadLine();

                        creator.WeeklyLikes = new double[4];

						Console.WriteLine("Enter weekly likes (Week 1 to 4):");

						for (int i = 0; i < 4; i++)
						{
							creator.WeeklyLikes[i] = double.Parse(Console.ReadLine());
						}

						program.RegisterCreator(creator);
						Console.WriteLine("Creator registered successfully");
						break;

					case 2:
						Console.WriteLine("Enter like threshold:");
						double threshold = double.Parse(Console.ReadLine());

						var topPosts = program.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

						if (topPosts.Count == 0)
						{
							Console.WriteLine("No top-performing posts this week");
						}
						else
						{
							foreach (var item in topPosts)
							{
								Console.WriteLine($"{item.Key} - {item.Value}");
							}
						}
						break;

					case 3:
						double average = program.CalculateAverageLikes();
						Console.WriteLine($"Overall average weekly likes: {average}");
						break;

					case 4:
						Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
						running = false;
						break;

					default:
						Console.WriteLine("Invalid choice. Try again.");
						break;

				}

			}
        }

	}
}
