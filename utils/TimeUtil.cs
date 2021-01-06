using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.utils
{
    class TimeUtil
    {
        public static string GetNow()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }

        public static long getSeconds(string strTime)
        {
            DateTime timea = Convert.ToDateTime(strTime);
            double intResult = 0;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            intResult = (timea - startTime).TotalSeconds;
            return Convert.ToInt64(intResult);
        }
    }
}
