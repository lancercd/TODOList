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
        //2020-12-13 10:10:10
        public static long getSeconds(string strTime)
        {
            DateTime timea = Convert.ToDateTime(strTime);
            double intResult = 0;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            intResult = (timea - startTime).TotalSeconds;
            return Convert.ToInt64(intResult);
        }


        //private DateTime getDateTime(int time)
        //{
        //    DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
        //    long lTime = ((long)time * 10000000);
        //    TimeSpan toNow = new TimeSpan(lTime);
        //    DateTime targetDt = dtStart.Add(toNow);
        //    return targetDt;
        //}


        public static string getDate(ulong second)
        {
            return Dt_to_string("yyyy-MM-dd hh:mm:ss", second);
        }

        public static string getShortDate(ulong second)
        {
            return Dt_to_string("MM-dd hh:mm", second);
        }

        public static string getDate(string str, ulong second)
        {
            return Dt_to_string(str, second);
        }

        private static string Dt_to_string(string str, ulong second)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime().AddSeconds(second - 28800);
            return dt.ToString(str);
        }
    }
}
