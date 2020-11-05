using System.Collections.Generic;
using COREAPI.Models;

namespace COREAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command{Id=0,HowTo="Boil en egg", Line="Boil Water", Platform="Kettle and Pan"},
                 new Command{Id=0,HowTo="Cut bread", Line="Get a Knife", Platform="Knife and Chopping Borad"},
                 new Command{Id=0,HowTo="Make cup of Tea", Line="Place teabag in cup", Platform="Kettle and Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0,HowTo="Boil en egg", Line="Boil Water", Platform="Kettle and Pan"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}