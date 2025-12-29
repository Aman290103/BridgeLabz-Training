/*Strings – Sentence Formatter
1. Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.*/     

using System;

    // Entry point
    public static void Main()
    {
        Console.WriteLine("------Welcome to the Sentence Formatter------");
        TakeInput();
    }

    // Method to take input
    public static void TakeInput()
    {
        Console.WriteLine("Enter your paragraph:");
        string strFromUser = Console.ReadLine();

        if(strFromUser==null || strFromUser==""){
            return;
        }

        Menu(strFromUser);
    }

    // Menu method
    public static void Menu(string strFromUser)
    {
        bool isExit = false;

        while (!isExit)
        {
            Console.WriteLine("\nChoose the operation you want to perform");
            Console.WriteLine("Press 1 : Add spacing after punctuation");
            Console.WriteLine("Press 2 : Remove extra spaces");
            Console.WriteLine("Press 3 : Capitalize sentence starts");
            Console.WriteLine("Press 4 : Do all operations");
            Console.WriteLine("Press 5 : Enter new input");
            Console.WriteLine("Press 6 : Exit");

            int menu;
            if (!int.TryParse(Console.ReadLine(), out menu))
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            if (menu < 1 || menu > 6)
            {
                Console.WriteLine("Invalid menu choice.");
                continue;
            }

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Result:");
                    Console.WriteLine(AddSpacesAfterPunctuation(strFromUser));
                    break;

                case 2:
                    Console.WriteLine("Result:");
                    Console.WriteLine(RemoveExtraSpaces(strFromUser));
                    break;

                case 3:
                    Console.WriteLine("Result:");
                    Console.WriteLine(CapitalParagraph(strFromUser));
                    break;

                case 4:
                    Console.WriteLine("Result:");
                    string result = AddSpacesAfterPunctuation(strFromUser);
                    result = RemoveExtraSpaces(result);
                    result = CapitalParagraph(result);
                    Console.WriteLine(result);
                    break;

                case 5:
                    TakeInput();
                    return;

                case 6:
                    Console.WriteLine("Exiting program...");
                    isExit = true;
                    break;
            }
        }
    }

    // Remove extra spaces
    public static string RemoveExtraSpaces(string str)
    {
        string res = "";
        bool spaceFound = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ' ')
            {
                res += str[i];
                spaceFound = false;
            }
            else if (!spaceFound)
            {
                res += ' ';
                spaceFound = true;
            }
        }

        // Trim trailing space
        if (res.Length > 0 && res[res.Length - 1] == ' ')
        {
            res = res.Substring(0, res.Length - 1);
        }

        return res;
    }

    // Capitalize sentence starts
    public static string CapitalParagraph(string str)
    {
        string res = "";
        bool capitalizeNext = true;

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];

            if (capitalizeNext && c >= 'a' && c <= 'z')
            {
                c = (char)(c - 32); // ASCII uppercase
            }

            res += c;

            if (c == '.' || c == '?' || c == '!')
                capitalizeNext = true;
            else if (c != ' ')
                capitalizeNext = false;
        }

        return res;
    }

    // Add space after punctuation
    public static string AddSpacesAfterPunctuation(string str)
    {
        string res = "";

        for (int i = 0; i < str.Length; i++)
        {
            res += str[i];

            if ((str[i] == '.' || str[i] == '?' || str[i] == '!' || str[i] == ',') &&
                i + 1 < str.Length && str[i + 1] != ' ')
            {
                res += ' ';
            }
        }

        return res;
    }
}
