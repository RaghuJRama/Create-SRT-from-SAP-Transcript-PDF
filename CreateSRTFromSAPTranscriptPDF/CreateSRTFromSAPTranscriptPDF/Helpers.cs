using System;
using System.Text.RegularExpressions;

namespace CreateSRTFromSAPTranscriptPDF
{
    public static class Helpers
    {
        public static bool isSRTModified = false;
        public static SRTInfo ModifiedSRT;

        public static string Left(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return (value.Length <= maxLength
                   ? value
                   : value.Substring(0, maxLength)
                   );
        }

        public static string Right(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return (value.Length <= maxLength
                   ? value
                   : value.Substring(value.Length - maxLength, maxLength)
                   );
        }

        public static bool isSRT(string text)
        {
            string strTime = text.Left(8);

            MatchCollection matches = Regex.Matches(strTime, @"\d\d:\d\d:\d\d");
            if (matches.Count == 1)
            {
                return true;
            }

            matches = Regex.Matches(strTime, @"\d:\d\d:\d\d");
            if (matches.Count == 1)
            {
                return true;
            }

            matches = Regex.Matches(strTime, @"\d:\d:\d\d");
            if (matches.Count == 1)
            {
                return true;
            }

            matches = Regex.Matches(strTime, @"\d\d:\d:\d\d");
            if (matches.Count == 1)
            {
                return true;
            }

            return false;
        }

        public static DateTime getTimeFromSRT(string text)
        {
            string strTime = text.Left(8);
            string[] timeSplit = strTime.Split(':');

            int hours = int.Parse(timeSplit[0]);
            int minutes = int.Parse(timeSplit[1]);
            int seconds = int.Parse(timeSplit[2]);

            return new DateTime(2000, 1 , 1, hours, minutes, seconds );
        }

        public static string getTextFromSRT(string text)
        {
            return text.Right(text.Length - 8).Trim();
        }

        public static bool isFooterContent(string text)
        {
            if (text.ToLower().Contains("page"))
            {
                if(text.ToLower().Contains("copyright"))
                {
                    if(text.ToLower().Contains("trademark"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static string getSRTTimeFormat(SRTInfo srtInfo)
        {
            string strTimeFormat = "";

            strTimeFormat = srtInfo.StartTime.ToString("HH:mm:ss,fff");
            strTimeFormat += " --> ";
            strTimeFormat += srtInfo.EndTime.ToString("HH:mm:ss,999");

            return strTimeFormat;
        }
    }
}
