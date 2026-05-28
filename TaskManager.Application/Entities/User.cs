namespace TaskManager.Application.Entities
{
    public class User
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
    }
}
