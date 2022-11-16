using System;
using System.Linq;

namespace Wiper
{
    public class Utils
    {
        public static string GetDate()
        {
            var time = DateTime.Now.ToString("hh-mm-ss"); // includes leading zeros
            var date = DateTime.Now.ToString("dd-MM-yy"); // includes leading zeros

            return date + "_" + time;
        }

        public static string[] GetFiles(string sourceFolder, string filters, System.IO.SearchOption searchOption)
        {
            try
            {
                return filters.Split('|')
                    .SelectMany(filter => System.IO.Directory.GetFiles(sourceFolder, filter, searchOption)).ToArray();
            }
            catch (Exception)
            {
                //throw;
            }
            return null;
        }
    }
}