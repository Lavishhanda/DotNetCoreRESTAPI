
using System.Collections.Generic;
using COREAPI.Models;

namespace COREAPI.Data
{
    public interface ICommanderRepo
    {
        bool saveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
    }
}