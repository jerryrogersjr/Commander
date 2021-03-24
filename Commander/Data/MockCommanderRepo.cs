using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil one Egg", Line = "Boil one water", Platform = "Kettle & Pan 1"},
                new Command{Id = 1, HowTo = "Boil two Egg", Line = "Boil two water", Platform = "Kettle & Pan 2"},
                new Command{Id = 2, HowTo = "Boil three Egg", Line = "Boil three water", Platform = "Kettle & Pan 3"}
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command{Id = 99, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}