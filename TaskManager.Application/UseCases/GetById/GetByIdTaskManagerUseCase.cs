using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.GetById
{
    public class GetByIdTaskManagerUseCase
    {
        public ReponseTaskManagerJson Execute(int id)
        {
            return new ReponseTaskManagerJson
            {
                Id = 10,
                Name = "Visual Studio",
                Descricao = "IDE",
                Priority = Communication.Enum.Priority.Media,
                DataLimite = DateTime.Now.AddDays(2),
                Status = Communication.Enum.Status.Aguardando,
            };
        }
    }
}
