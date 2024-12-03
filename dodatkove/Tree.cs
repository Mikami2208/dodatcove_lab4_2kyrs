namespace dodatkove;

public class Tree : Plants
{
    public Tree(string name, int dailyWaterNeed) : base(name, dailyWaterNeed) {}
    public override string ShowInfo()
    {
        return $"Дерево: {_name}, добова потреба у воді: {_dailyWaterNeed} мл.";
    }
}