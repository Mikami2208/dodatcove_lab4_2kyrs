namespace dodatkove;

public class Bush : Plants
{
    public Bush(string name, int dailyWaterNeed) : base(name, dailyWaterNeed) { }
    public override string ShowInfo()
    {
        return $"Кущ: {_name}, добова потреба у воді: {_dailyWaterNeed} мл.";
    }
}