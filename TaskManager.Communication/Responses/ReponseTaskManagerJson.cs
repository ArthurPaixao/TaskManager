using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Responses
{
    public class ReponseTaskManagerJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public DateTime DataLimite { get; set; }
        public Status Status { get; set; }
    }
}
