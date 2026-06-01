namespace TaskManager.Application.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DataLimite { get; set; }
        public int Status { get; set; }    
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
