namespace dodatkove;

public class Grass : Plants
{
    public Grass(string name, int dailyWaterNeed) : base(name, dailyWaterNeed) { }
    public override string ShowInfo()
    {
        return $"Трава: {_name}, добова потреба у воді: {_dailyWaterNeed} мл.";
    }
}