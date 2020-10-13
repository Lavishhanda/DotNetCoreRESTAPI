using Microsoft.AspNetCore.Mvc;
using COREAPI.Models;
using System.Collections.Generic;
using COREAPI.Data;
using Microsoft.AspNetCore.Cors;

namespace COREAPI.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //Get api/commands will hit this
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        //GET request for api/command/{id} a number for Id
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}