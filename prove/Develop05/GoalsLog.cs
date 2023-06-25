using System.IO;
using System.Linq; 
public class GoalsLog
{
    private List<Goal> _goals;
    private int _currentScore;
    public GoalsLog()
    {
        _goals = new List<Goal>();
        _currentScore = 0;
    }
    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
    }
    public int GetCurrentScore()
    {
        return _currentScore;
    }
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_currentScore);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    public void Load(string filename)
    {   
        this._goals.Clear();
        int score = int.Parse(System.IO.File.ReadLines(filename).First());
        _currentScore = score;

        string[] lines = System.IO.File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string goalType = line.Substring(0, line.IndexOf(":"));
            string cleanLine = line.Remove(0, goalType.Length + 1);
            
            string[] parts = cleanLine.Split(",");

            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            
            if (goalType == "SimpleGoal")
            {
                bool completed = false;
                if (parts[3] == "True")
                {
                    completed = true;
                }
                SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points, completed);
                this._goals.Add(newSimpleGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal newEternalGoal = new EternalGoal(name, description, points);
                this._goals.Add(newEternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonusPoints = int.Parse(parts[3]);
                int timesNeeded = int.Parse(parts[4]);
                int timesCompleted = int.Parse(parts[5]);
                bool completed = false;
                if (timesCompleted == timesNeeded)
                {
                    completed = true;
                }

                ChecklistGoal newChecklistGoal = new ChecklistGoal(name, description, points, timesNeeded, bonusPoints, timesCompleted, completed);
                this._goals.Add(newChecklistGoal);
            }
            else if (goalType == "NegativeGoal")
            {
                NegativeGoal newNegativeGoal = new NegativeGoal(name, description, points);
                this._goals.Add(newNegativeGoal);
            }
        }
    }
    public void DisplayList()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }
    public void RecordEvent(int goalIndex)
    {   
        if (_goals[goalIndex].IsComplete())
        {
            Console.WriteLine("This goal has already been accomplished.");
        }
        else
        {
            int pointsGained = _goals[goalIndex].RecordEvent();
            _currentScore += pointsGained;
            if (pointsGained >= 0)
            {
                Console.WriteLine($"Congratulations! You have earned {pointsGained} points!");
            }
            else 
            {
                Console.WriteLine($"You have lost {pointsGained} points. Failure is a stepping stone to success. Keep pushing forward.");
            }
            
            Console.WriteLine($"You now have {_currentScore} points.");
        }
        
    }
}