using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Register
{
    public class RegisterTaskManagerUseCase
    {
        public ResponseRegisteredTaskManagerJson Execute(RequestTaskManagerJson request)
        {
            return new ResponseRegisteredTaskManagerJson
            {
                Id = 1,
                Name = request.Name,

            };
        }
    }
}
