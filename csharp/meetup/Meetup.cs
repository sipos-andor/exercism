using System;
using System.Linq;

public enum Schedule { First = 0, Second = 7, Teenth = 12, Third = 14, Fourth = 21, Last }

public class Meetup
{
    int daysInCurrentMonth;
    DateTime date;
    public Meetup(int month, int year)
    {
        date = new DateTime(year, month, 1);
        daysInCurrentMonth = DateTime.DaysInMonth(year, month);
    }
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        => date.AddDays(Enumerable.Range(schedule != Schedule.Last ? (int)schedule : daysInCurrentMonth - 7, daysInCurrentMonth - (int)schedule).FirstOrDefault(d => date.AddDays(d).DayOfWeek == dayOfWeek));
}