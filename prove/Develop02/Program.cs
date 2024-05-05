using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {


        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write("\nWelcome to the Journal Program!\n");
        
        Journal journal = new Journal();


        while (action != 5)
        {

            action = Choices();

            switch (action)
            {
                case 1:
                    string dateInfo = GetDateTime();
                    string prompt = JournalPrompts();
                    JournalEntry entry = new JournalEntry();
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);


                    break;
                case 2:

                    journal.Display();

                    break;
                case 3:

                    journal.LoadJournalFile();
    
                    break;
                case 4:
          
                    journal.CreateJournalFile();
      
                    break;
                case 5:
                
                    Console.WriteLine("\nThank you for use the Journal Program!\n");
                    break;
                default:
                    Console.WriteLine("\nSorry that's not a valid choice!");
                    break;
            }
        }


    }

    static string JournalPrompts()
    {
        var random = new Random();

        var prompt = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            
        };
        int index = random.Next(prompt.Count);
        string journalPrompt = prompt[index];
        Console.WriteLine($"\n{journalPrompt}");

        return journalPrompt;
    }


    static int Choices()
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);


        return action;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");

        return currentDateTime;
    }
    static void AddJournalEntry()
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }


}