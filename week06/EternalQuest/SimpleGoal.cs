public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) { }

    public SimpleGoal(string name, string description, int points, bool isComplete) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}