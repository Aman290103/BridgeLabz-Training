using System;

public class Voting{
    static string[] candidates = new string[5];
    static int[] votes = new int[5];
    static int candidateCount = 0;

    static void Main(){
        while (true){
            Console.WriteLine("\n--- VOTING SYSTEM ---");
            Console.WriteLine("1. Admin Menu");
            Console.WriteLine("2. Voter Menu");
            Console.WriteLine("3. Show Results");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice){
                case 1:
                    AdminMenu();
                    break;
                case 2:
                    VoterMenu();
                    break;
                case 3:
                    ShowResult();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the voting system!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void AdminMenu(){
        Console.WriteLine("\n--- ADMIN MENU ---");
        Console.Write("Enter number of candidates: ");
        candidateCount = Convert.ToInt32(Console.ReadLine());
        
        if (candidateCount > 5){
            Console.WriteLine("Maximum 5 candidates allowed.");
            candidateCount = 5;
        }
        
        for (int i = 0; i < candidateCount; i++){
            Console.Write($"Enter name of candidate {i + 1}: ");
            candidates[i] = Console.ReadLine();
            votes[i] = 0;
        }
        Console.WriteLine("Candidates registered successfully!");
    }

    public static void VoterMenu(){
        if (candidateCount == 0){
            Console.WriteLine("No candidates available. Please contact admin.");
            return;
        }
        
        Console.WriteLine("\n--- VOTER MENU ---");
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18){
            Console.WriteLine("You are not eligible to vote. Minimum age is 18.");
            return;
        }

        Console.WriteLine("\n--- Candidates List ---");
        for (int i = 0; i < candidateCount; i++){
            Console.WriteLine($"{i + 1}. {candidates[i]}");
        }

        Console.Write("Enter candidate number to vote: ");
        int voteChoice = Convert.ToInt32(Console.ReadLine());

        if (voteChoice >= 1 && voteChoice <= candidateCount){
            votes[voteChoice - 1]++;
            Console.WriteLine("Vote cast successfully!");
        }
        else{
            Console.WriteLine("Invalid candidate selection.");
        }
    }

    static void ShowResult(){
        if (candidateCount == 0){
            Console.WriteLine("No election data available. Please register candidates first.");
            return;
        }

        Console.WriteLine("\n--- ELECTION RESULTS ---");
        int maxVotes = votes[0];
        int winnerIndex = 0;

        for (int i = 0; i < candidateCount; i++){
            Console.WriteLine($"{candidates[i]}: {votes[i]} votes");

            if (votes[i] > maxVotes){
                maxVotes = votes[i];
                winnerIndex = i;
            }
        }

        if (maxVotes == 0){
            Console.WriteLine("\nNo votes cast yet.");
        }
        else{
            Console.WriteLine($"\nWINNER: {candidates[winnerIndex]} with {maxVotes} votes!");
        }
    }
}      