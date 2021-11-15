namespace Ecommerce2.Util
{
    public static class DateUtilities
    {
        public static int GetIntYears(TimeSpan timeSpan)
        {
            return (timeSpan.Days / 365);
        }

    }
}