using System;
using System.Security.Cryptography.X509Certificates;
using V1._0._1;
using System.IO;
using System.Threading;
using System.Runtime.CompilerServices;

namespace V1._0._1
{
    class ClassCreateNewSave
    {
        // Variables used
        protected string OriginFolderPath;
        protected string DestinationFolderPath;
        protected string SaveName;
        protected string SaveType;
        protected string SaveTypeLower;

        // Constructor
        public ClassCreateNewSave()
        {
        }

        /// Clear everything before starting
        public void ClearEverything()
        {
            Console.Clear();
        }

        /// Sub choice 1 : choose folder to copy
        public string SubChoice1()
        {
            Console.WriteLine("Give the path of the folder you want to copy");
            OriginFolderPath = Console.ReadLine();
            Console.WriteLine("\n");
            while (!Directory.Exists(OriginFolderPath))
            {
                Console.WriteLine("The path must exist. Check for spelling error");
                OriginFolderPath = Console.ReadLine();
                Console.WriteLine("\n");
            }
            return OriginFolderPath;
        }

        /// Sub choice 2 : choose where to save
        public string SubChoice2()
        {
            Console.WriteLine("Give the path of the destination");
            DestinationFolderPath = Console.ReadLine();
            Console.WriteLine("\n");
            while (!Directory.Exists(DestinationFolderPath))
            {
                Console.WriteLine("The path must exist. Check for spelling error");
                DestinationFolderPath = Console.ReadLine();
                Console.WriteLine("\n");
            }
            return DestinationFolderPath;
        }

        /// Sub choice 3 : choose a name
        public string SubChoice3()
        {
            Console.WriteLine("Give your save a name");
            SaveName = Console.ReadLine();
            Console.WriteLine("\n");
            while (SaveName.Length < 5 || SaveName.Length > 30)
            {
                Console.WriteLine("The name must be between 5 and 30 characters");
                SaveName = Console.ReadLine();
                Console.WriteLine("\n");
            }
            return SaveName;
        }

        /// Sub choice 4 : choose a type
        public string SubChoice4()
        {
            Console.WriteLine("What type of save do you want : Complete or Differential");
            SaveType = Console.ReadLine();
            SaveTypeLower = SaveType.ToLower();
            Console.WriteLine("\n");
            while (!(SaveTypeLower.Equals("complete") || SaveTypeLower.Equals("differential")))
            {
                Console.WriteLine("Wrong input. Please enter COMPLETE or DIFFERENTIAL");
                SaveType = Console.ReadLine();
                SaveTypeLower = SaveType.ToLower();
                Console.WriteLine("\n");
            }
            return SaveType;
        }

        // End of CreateNewSave
        public void EndLoading()
        {
            Console.Clear();
            string text = ".";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(text);
                Thread.Sleep(500);
                Console.Clear();
                text += ".";
            }

            Console.Clear();
            Console.WriteLine("Task was sucessfuly done");
            Thread.Sleep(2000);
        }
    }
}
