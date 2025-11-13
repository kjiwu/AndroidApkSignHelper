using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidApkSignHelper
{
    internal class TimeHelper
    {
        private string UTCToLocal(string utcTime)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(utcTime, "yyyyMMddHHmmss", CultureInfo.CurrentCulture);
                TimeZoneInfo localTime = TimeZoneInfo.Local;
                DateTime dateTime = TimeZoneInfo.ConvertTimeFromUtc(dt, localTime);
                return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch
            {
                return "";
            }
        }

        public string ConvertVersionTime(string days)
        {
            if (string.IsNullOrEmpty(days))
            {
                return "";
            }

            try
            {
                DateTime dateTime = new DateTime(2017, 7, 1);
                dateTime = dateTime.AddDays(double.Parse(days));
                return dateTime.ToString("yyyy-MM-dd");
            }
            catch
            {
                return "";
            }
        }

        public string ConvertPackageTime(string days)
        {
            if (string.IsNullOrEmpty(days))
            {
                return "";
            }
            return UTCToLocal(days);
        }

        public string ConvertTime(string strTime)
        {
            if (string.IsNullOrEmpty(strTime))
            {
                return "";
            }

            try
            {
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0);
                long time = long.Parse(strTime) * 10000 + dateTime.Ticks;

                DateTime dt = new DateTime(time);
                TimeZoneInfo localTime = TimeZoneInfo.Local;
                DateTime result = TimeZoneInfo.ConvertTimeFromUtc(dt, localTime);
                return result.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch
            {
                return "";
            }
        }
    }
}
