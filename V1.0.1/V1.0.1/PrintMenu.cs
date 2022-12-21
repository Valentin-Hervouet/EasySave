using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V1._0._1
{
    class ClassPrintMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("EasySave 1.0.1\n");
            Console.WriteLine("\r\n _____                  _____                 \r\n|  ___|                /  ___|                \r\n| |__  __ _ ___ _   _  \\ `--.  __ ___   _____ \r\n|  __|/ _` / __| | | |  `--. \\/ _` \\ \\ / / _ \\\r\n| |__| (_| \\__ \\ |_| | /\\__/ / (_| |\\ V /  __/\r\n\\____/\\__,_|___/\\__, | \\____/ \\__,_| \\_/ \\___|\r\n                 __/ |                        \r\n                |___/                         \r\n");
            Console.WriteLine("Make a choice :\n\nCreateNewSave : To create a new save\nSave : To list existing save\nShowDailyLog : To Show daily log\nShowStateLog : To show state log\nClear : To clear everything\nExit : To exit\n");
            Console.Title = "EasySave 1.0.1";
        }

        public void ClearEverything()
        {
            Console.Clear();
        }
    }
}
