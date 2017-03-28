using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPF1.Utilities
{
    public static class Log
    {
        private static StreamWriter writer = new StreamWriter(String.Concat(@"C:\Users\admin\Desktop\DR\Project\WPF1\Log" + String.Format("{0: yyyyMMddhhmmss}", DateTime.Now) + ".log"), false, Encoding.UTF8);

        public static void recordLog(string pmsg)
        {
            lock (writer)
            {
                writer.WriteLine(String.Concat(DateTime.Now, pmsg));
                writer.Flush();
            }
        }

        public static void closeLog()
        {
            if (!writer.Equals(null))
            {
                writer.WriteLine(String.Concat(DateTime.Now, "#close program log#"));
                writer.Flush();

                writer.Close();
                writer = null;
            }
        }
    }
}
