using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.GetAll
{
    public class GetAllTaskManagerUseCase
    {
        public ReponseAllTaskManagerJson Execute()
        {
            return new ReponseAllTaskManagerJson
            {
                TaskManager = new List<ResponseShortTaskManagerJson>
                {
                    new ResponseShortTaskManagerJson
                    {
                        Id = 5,
                        Name = "Sql Server",
                        Descricao = "Ferramenta de banco de dados",
                        Priority = Communication.Enum.Priority.Alta,
                        DataLimite = DateTime.Now.AddDays(1),
                        Status = Communication.Enum.Status.EmAndamento,
                    }
                }
            };
        }
    }
}
