namespace dodatkove;

public abstract class Plants : INature
{
    protected string _name;
    protected int _dailyWaterNeed;
    protected int _currentWater;

    public Plants(string name, int dailyWaterNeed)
    {
        _name = name;
        _dailyWaterNeed = dailyWaterNeed;
        _currentWater = 0;
    }

    public string Feed(int feedWater)
    {
        _currentWater += feedWater;
        if (_currentWater < _dailyWaterNeed)
        {
            return $"{_name} потрібно ще полити. Кількість мл. води, яку потрібно додати: {_dailyWaterNeed - _currentWater}";
        } else if (_currentWater > _dailyWaterNeed)
        {
            return
                $"{_name} полито достатньо, але в наступний раз полийте меньшою кількістю води, а точніше: {_dailyWaterNeed}";
        }
        else
        {
            return $"{_name} полито достатньо";
        }
    }

    public virtual string ShowInfo()
    {
        return $"Рослина: {_name}, добова потреба у воді: {_dailyWaterNeed} мл.";
    }
}