namespace TaskManager.Application.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string Description { get; set; }
        private int Priority { get; set; }
        private DateTime DataLimite { get; set; }
        private int Status { get; set; }    
        private int UserId { get; set; }
        private User User { get; set; }
    }
}
