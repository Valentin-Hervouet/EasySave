using System;
using System.Security.Cryptography.X509Certificates;
using V1._0._1;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        // We open the app menu
        Console.WriteLine("EasySave 1.0.1\n");
        Console.WriteLine("\r\n _____                  _____                 \r\n|  ___|                /  ___|                \r\n| |__  __ _ ___ _   _  \\ `--.  __ ___   _____ \r\n|  __|/ _` / __| | | |  `--. \\/ _` \\ \\ / / _ \\\r\n| |__| (_| \\__ \\ |_| | /\\__/ / (_| |\\ V /  __/\r\n\\____/\\__,_|___/\\__, | \\____/ \\__,_| \\_/ \\___|\r\n                 __/ |                        \r\n                |___/                         \r\n");
        Console.WriteLine("Make a choice :\n\nCreateNewSave : To create a new save\nSave : To list existing save\nShowDailyLog : To Show daily log\nShowStateLog : To show state log\nExit : To exit\n");
        Console.Title = "EasySave 1.0.1";

        // We let the user make a choice
        string MenuChoice;
        string MenuChoiceLower;
        bool vrai = true;

        while (vrai)
        {
            /// We prompt the user for a string
            MenuChoice = Console.ReadLine();
            MenuChoiceLower = MenuChoice.ToLower();

            switch (MenuChoiceLower)
            {
                // Choice 1 : create a new save
                case "createnewsave":
                    CreateNewSave a = new CreateNewSave();
                    Console.WriteLine("EasySave 1.0.1\n");
                    Console.WriteLine("\r\n _____                  _____                 \r\n|  ___|                /  ___|                \r\n| |__  __ _ ___ _   _  \\ `--.  __ ___   _____ \r\n|  __|/ _` / __| | | |  `--. \\/ _` \\ \\ / / _ \\\r\n| |__| (_| \\__ \\ |_| | /\\__/ / (_| |\\ V /  __/\r\n\\____/\\__,_|___/\\__, | \\____/ \\__,_| \\_/ \\___|\r\n                 __/ |                        \r\n                |___/                         \r\n");
                    Console.WriteLine("Make a choice :\n\nCreateNewSave : To create a new save\nSave : To list existing save\nShowDailyLog : To Show daily log\nShowStateLog : To show state log\nExit : To exit\n");
                    break;

                // Choice 2 : save
                case "save":

                    // Sub choice 1 : save 1 save

                    // Sub choice 2 : save all save
                    break;

                // Choice 3 : show daily log
                case "showdailylog":
                    break;

                // Choice 4 : show state log
                case "showstatelog":
                    break;

                // Choice 5 : exit
                case "exit" :
                    vrai = false;
                    break;

                // In case the user type something else
                default:
                    Console.WriteLine("\nType again \n");
                    break;
            }
        }
    }
}