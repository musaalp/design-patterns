namespace Command
{
    public class DatabaseCommander
    {
        public void Execute(ICommand command)
        {
            command.Execute();
        }
    }
}
