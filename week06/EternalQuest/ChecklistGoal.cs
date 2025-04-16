public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, 
        int targetCount, int bonusPoints) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public ChecklistGoal(string name, string description, int points, 
        int targetCount, int bonusPoints, int currentCount) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = currentCount;
        _isComplete = (currentCount >= targetCount);
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) " +
               $"- Completed {_currentCount}/{_targetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points}," +
               $"{_bonusPoints},{_targetCount},{_currentCount}";
    }

    public override int GetPoints()
    {
        return _isComplete ? 
            (_points * _currentCount) + _bonusPoints : 
            _points * _currentCount;
    }
}