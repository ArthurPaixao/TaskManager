using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TaskManager.Application.UseCases.GetAll;
using TaskManager.Application.UseCases.GetById;
using TaskManager.Application.UseCases.Register;
using TaskManager.Application.UseCases.Update;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManager : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredTaskManagerJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register(RequestTaskManagerJson request)
        {
            var response = new RegisterTaskManagerUseCase().Execute(request);

            return Created(string.Empty, request);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseShortTaskManagerJson>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTaskManagerUseCase();

            var response = useCase.Execute();

            if (response.TaskManager.Any())
            {
                return Ok(response);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ReponseTaskManagerJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult GetByID(int id)
        {
            var useCase = new GetByIdTaskManagerUseCase();

            var response = useCase.Execute(id);

            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, RequestTaskManagerJson request)
        {
            var response = new UpdateTaskManagerUseCase();

            response.Execute(id, request);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

        public IActionResult Delete(int id)
        {
            var useCase = new ResponseDeleteByIdTaskManagerJson();
            useCase.Execute(id);

            return NoContent();
        }
    }
}
