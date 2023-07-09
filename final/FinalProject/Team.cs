public class Team : User
{
    private string _teamName;
    private List<User> _teamMembers;

    public Team(string username, string password, string teamName) : base(username, password)
    {
        _teamName = teamName;
        _teamMembers = new List<User>();
    }

    public override void AssignTask(Task task, User assignee)
    {
        if (assignee == this)
        {
            // Assign the task to the current user
            this.AddTask(task);
        }
        else
        {
            // Assign the task to another user
            assignee.AddTask(task);
        }

        foreach (User user in _teamMembers)
        {
            user.AssignTask(task, user);
        }
    }

    public void AddTeamMember(User user)
    {
        _teamMembers.Add(user);
    }

    public void RemoveTeamMember(User user)
    {
        _teamMembers.Remove(user);
    }
}