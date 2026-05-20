using System.Globalization;

namespace AllameDehkhoda.Presentation.Common
{
    public static class DateTimeFuncs
    {
        public static object ToShamsi(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";

        }
    }
}
