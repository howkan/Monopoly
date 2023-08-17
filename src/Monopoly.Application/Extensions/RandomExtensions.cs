namespace Monopoly.Application.Extensions;

public static class RandomExtensions
{
    public static DateOnly NextDate(this Random random)
    {
        var now = DateTime.Now;

        var startDate = new DateTime(now.Year - 5, now.Month, now.Day);

        TimeSpan timeSpan = DateTime.Now - startDate;

        TimeSpan newSpan = new(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);

        return DateOnly.FromDateTime(startDate + newSpan);
    }
}