using System;

namespace Ripley.Core
{
    public static class Extensions
    {
        public static DateTime ToUtc(this DateTime dateTime)
        {
            return dateTime.ToUniversalTime();
        }
    }
}
