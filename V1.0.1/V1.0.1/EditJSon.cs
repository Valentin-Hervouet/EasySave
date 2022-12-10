using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace V1._0._1
{
    class ClassEditJSon
    {
        // Give the pth of the json files in the computer.
        public string statepath = "C:\\Users\\Valentin\\Desktop\\ProgramationSysteme\\V1.0.1\\V1.0.1\\V1.0.1\\json\\Sample_state.json";
        public string dailypath = "C:\\Users\\Valentin\\Desktop\\ProgramationSysteme\\V1.0.1\\V1.0.1\\V1.0.1\\json\\Sample_log.json";

        //public string OriginFolderPath
        //public string DestinationFolderPath;
        //public string DestPath;
        //public string SaveName;
        //public string SaveType;
        //public long FileSize;
        //public string FileTransferTime;
        //public DateTime Time;

        // Constructor
        /*
        public SaveIntoLogPath()
        {
        }
        */

        // Write in Sample Log JSon File
        public void SaveIntoLogPath(string OriginFolderPath, string DestinationFolderPath, string SaveName, string SaveType)
        {
            /// New variables used
            string DestPath = "";
            long FileSize = 42;
            string FileTransferTime = "42";
            DateTime Time = DateTime.Now;

            /// Concatenate all the information
            string CreateSaveData = SaveName + "," + OriginFolderPath + "," + DestinationFolderPath + "," + DestPath + "," + FileSize.ToString() + "," + FileTransferTime + "," + Time.ToString();

            /// Convert the tring into a list
            List<string> ListCreateSaveData = CreateSaveData.Split(',').ToList();

            /// Write into JSon
            string updatedJson = JsonConvert.SerializeObject(ListCreateSaveData, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.dailypath, updatedJson);
        }
    }
}
