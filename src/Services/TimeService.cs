public interface ITimeService
{
    string GetGreeting();
}

public class TimeService : ITimeService
{
    public string GetGreeting()
    {
        DateTime currentTime = DateTime.Now;

        if (currentTime.Hour >= 12 && currentTime.Hour < 18) return "Midday";
        if (currentTime.Hour >= 18 && currentTime.Hour < 24) return "Evening";
        if (currentTime.Hour >= 0 && currentTime.Hour < 6) return "Night";
        if (currentTime.Hour >= 1 && currentTime.Hour < 12) return "Morning";

        return "error";
    }
}