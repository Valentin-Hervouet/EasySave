using System;
using V1._0._1;

internal class Program
{
    private static void Main(string[] args)
    {
        // We open the app menu
        Console.WriteLine("EasySave 1.0.1\n");

        // We let the user make a choice
        string MenuChoice = null;

        while (MenuChoice != "exit")
        {


            Console.WriteLine("Make a choice :\n\nCreateNewSave : To create a new save\nSave : To list existing save\nShowDailyLog : To Show daily log\nShowStateLog : To show state log\nExit : To exit\n");

            MenuChoice = Console.ReadLine();

            /// We prompt the user for a string
            switch (MenuChoice)
            {
                // Choice 1 : create a new save
                case "CreateNewSave":

                    // Sub choice 1 : choose folder to copy

                    // Sub choice 2 : choose the number of save

                    // Sub choice 3 : choose where to save

                    // Sub choice 4 : choose where to save

                    // Sub choice 5 : choose a name

                    // Sub choice 6 : choose a type
                    break;

                // Choice 2 : save
                case "Save":

                    // Sub choice 1 : save 1 save

                    // Sub choice 2 : save all save
                    break;

                // Choice 3 : show daily log
                case "ShowDailyLog":
                    break;

                // Choice 4 : show state log
                case "ShowStateLog":
                    break;

                // Choice 5 : exit
                case "Exit":
                    break;
            }
        }
    }
}