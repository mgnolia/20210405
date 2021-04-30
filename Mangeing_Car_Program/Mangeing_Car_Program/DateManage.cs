using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangeing_Car_Program
{
    class DateManage
    {
        public static void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");

            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter(@"parkinghistory\parkinghistory.txt"))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
