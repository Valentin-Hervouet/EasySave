using System;
using System.Security.Cryptography.X509Certificates;
using V1._0._1;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        // We open the app menu
        ClassPrintMenu DisplayMenuPrintMenu = new ClassPrintMenu();
        DisplayMenuPrintMenu.DisplayMenu();

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
                    ClassCreateNewSave MenuChoiceCreateNewSave = new ClassCreateNewSave();
                    MenuChoiceCreateNewSave.ClearEverything();
                    MenuChoiceCreateNewSave.SubChoice1();
                    MenuChoiceCreateNewSave.SubChoice2();
                    MenuChoiceCreateNewSave.SubChoice3();
                    MenuChoiceCreateNewSave.SubChoice4();
                    MenuChoiceCreateNewSave.EndLoading();
                    MenuChoiceCreateNewSave.ClearEverything();

                    DisplayMenuPrintMenu.DisplayMenu();


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