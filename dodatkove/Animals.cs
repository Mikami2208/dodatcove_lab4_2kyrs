namespace dodatkove;

public class Animals : INature
{
    protected string _name;
    protected int _dailyFeedNeed;
    protected int _currentFeed;

    public Animals(string name, int dailyFeedNeed)
    {
        _name = name;
        _dailyFeedNeed = dailyFeedNeed;
        _currentFeed = 0;
    }

    public virtual string Feed(int amountOfFeed)
    {
        _currentFeed += amountOfFeed;
        if (_currentFeed >= _dailyFeedNeed)
            return $"{_name} нагодована!";
        else
            return $"{_name} потребує ще {_dailyFeedNeed - _currentFeed} грам корму.";
    }

    public virtual string ShowInfo()
    {
        return $"Тварина: {_name}, добова потреба в кормі: {_dailyFeedNeed} грам.";
    }
}