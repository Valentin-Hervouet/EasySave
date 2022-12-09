using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1._0._1
{
    class ClassEditJSon
    {
        // Give the pth of the json files in the computer.
        public string statepath = "Users/Valentin/Desktop/Programation Systeme/V1.0.1/V1.0.1/V1.0.1/json/Samle_state.json";
        public string dailypath = "Users/Valentin/Desktop/Programation Systeme/V1.0.1/V1.0.1/V1.0.1/json/Samle_log.json";


    }

    public class SaveIntoStatePath
    {
        public string OriginFolderPath;
        public string DestinationFolderPath;
        public string SaveName;
        public string SaveType;
        public long FileSize;
        public string FileTransferTime;
        public DateTime Time;

        /*
        // Constructor
        public ClassEditJSon()
        {
        }
        */

    }

}
