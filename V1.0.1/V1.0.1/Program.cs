using System;
using System.Security.Cryptography.X509Certificates;
using V1._0._1;
using System.IO;


internal class Program
{
    private static void Main(string[] args)
    {
        // We open the app menu
        /// We initiate all that will be used later on
        ClassPrintMenu DisplayMenuPrintMenu = new ClassPrintMenu();
        ClassCreateNewSave MenuChoiceCreateNewSave = new ClassCreateNewSave();

        /// We print the menu
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
                    DisplayMenuPrintMenu.ClearEverything();
                    string OriginFolderPath = MenuChoiceCreateNewSave.SubChoice1();
                    string DestinationFolderPath = MenuChoiceCreateNewSave.SubChoice2();
                    string SaveName = MenuChoiceCreateNewSave.SubChoice3();
                    string SaveType = MenuChoiceCreateNewSave.SubChoice4();
                    MenuChoiceCreateNewSave.EndLoading();
                    DisplayMenuPrintMenu.ClearEverything();

                    /// Write inputs on the log file Json
                    ClassEditJSon MenuChoiceEditJSon = new ClassEditJSon();
                    MenuChoiceEditJSon.SaveIntoLogPath(OriginFolderPath, DestinationFolderPath, SaveName, SaveType);

                    /// Go back on the menu
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
                case "exit":
                    vrai = false;
                    break;

                // Choice 6 : clear
                case "clear":
                    DisplayMenuPrintMenu.ClearEverything();
                    DisplayMenuPrintMenu.DisplayMenu();
                    break;

                // In case the user type something else
                default:
                    Console.WriteLine("\nType again \n");
                    break;
            }
        }
    }
}