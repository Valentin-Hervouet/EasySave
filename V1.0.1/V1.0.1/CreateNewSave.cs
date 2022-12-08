﻿using System;
using System.Security.Cryptography.X509Certificates;
using V1._0._1;
using System.IO;

namespace V1._0._1
{
    public class CreateNewSave
    {
        public CreateNewSave()
        {
            // Variables used
            string OriginFolderPath;
            string DestinationFolderPath;
            string SaveName;
            string SaveType;
            string SaveTypeLower;

            Console.Clear();

            /// Sub choice 1 : choose folder to copy
            Console.WriteLine("Give the path of the folder you want to copy");
            OriginFolderPath = Console.ReadLine();
            Console.WriteLine("\n");
            while (!Directory.Exists(OriginFolderPath))
            {
                Console.WriteLine("The path must exist. Check for spelling error");
                OriginFolderPath = Console.ReadLine();
                Console.WriteLine("\n");
            }

            /// Sub choice 2 : choose where to save
            Console.WriteLine("Give the path of the destination");
            DestinationFolderPath = Console.ReadLine();
            Console.WriteLine("\n");
            while (!Directory.Exists(DestinationFolderPath))
            {
                Console.WriteLine("The path must exist. Check for spelling error");
                DestinationFolderPath = Console.ReadLine();
                Console.WriteLine("\n");
            }

            /// Sub choice 3 : choose a name
            Console.WriteLine("Give your save a name");
            SaveName = Console.ReadLine();
            Console.WriteLine("\n");
            while (SaveName.Length < 5 || SaveName.Length > 30)
            {
                Console.WriteLine("The name must be between 5 and 30 characters");
                SaveName = Console.ReadLine();
                Console.WriteLine("\n");
            }

            /// Sub choice 4 : choose a type
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

            // End of this
            Console.Clear();
        }
    }
}
