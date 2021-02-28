using System;

namespace PubSub
{
    public static class StringExtension
    {
        public static string SateliteTransmissionFormat(this string str, DateTime dateTime)
        {
            return dateTime.ToLongTimeString() + ": " + str;
        }
    }
}
