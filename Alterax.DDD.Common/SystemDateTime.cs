namespace Alterax.DDD.Common
{
    using System;

    public static class SystemDateTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
        public static void Reset()
        {
            Now = () => DateTime.Now;
        }
    }
}