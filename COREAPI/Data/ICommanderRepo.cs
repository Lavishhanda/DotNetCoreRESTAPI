
using System.Collections.Generic;
using COREAPI.Models;

namespace COREAPI.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}