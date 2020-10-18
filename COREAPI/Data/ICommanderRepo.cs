
using System.Collections.Generic;
using COREAPI.Models;

namespace COREAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}