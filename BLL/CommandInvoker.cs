
public class CommandInvoker
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public async Task ExecuteCommandAsync()
    {
       await command.ExecuteAsync();
    }
}