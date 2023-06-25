public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
        _points = points * -1;
    }
    public override int RecordEvent()
    {
        int pointsLost = _points;
        return pointsLost; 
    }
    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_name},{_description},{_points}";
    }
}