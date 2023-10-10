public static class DateOnlyExtension
{
    public static DateTimeOffset ToDateTimeOffset(this DateOnly dateOnly, TimeZoneInfo timeZoneInfo)
    {
        var dateTime = dateOnly.ToDateTime(TimeOnly.MinValue);
        return new DateTimeOffset(dateTime, timeZoneInfo.GetUtcOffset(dateTime));
    }

    public static DateTimeOffset? ToDateTimeOffset(this DateOnly? dateOnly, TimeZoneInfo timeZoneInfo)
    {
        if (dateOnly.HasValue)
        {
            var dateTime = dateOnly.Value.ToDateTime(TimeOnly.MinValue);
            return new DateTimeOffset(dateTime, timeZoneInfo.GetUtcOffset(dateTime));
        }
        return null;
    }
}
