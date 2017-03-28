using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1.Utilities
{
    public static class Configuration
    {
        private static Hashtable Statement = new Hashtable();

        public static String getConfiguration(String code)
        {
            String ret = "";

            lock (Statement)
            {
                if (Statement.Count.Equals(0))
                {
                    String[] vlines = System.IO.File.ReadAllLines(@"C:\\Users\\admin\\Desktop\\DR\\Project\\WPF1\\WPF1\\bin\\Debug\\resources\\resource.txt");
                 
                    foreach (String vline in vlines)
                    {
                        if (vline.Trim().Length > 0)
                            Statement[(String)vline.Substring(0, 8)] = (String)vline.Substring(9);
                    }

                }

                ret = (String)Statement[code].ToString().Trim();
            }
            return code;
        }


    }
}
