namespace ContactsManager.models
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public int Priority { get; set; } // 1-5 (stars)
        public TaskStatus Status { get; set; }
        public bool IsCompleted { get; set; }
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        Urgent
    }
}
