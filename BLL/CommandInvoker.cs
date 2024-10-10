using SF.HW03.Task18._4._1.BLL.Commands;

namespace SF.HW03.Task18._4._1.BLL;

/// <summary>
/// Класс CommandInvoker отвечает за выполнение команд, реализующих интерфейс ICommand.
/// </summary>
public class CommandInvoker
{
    private ICommand command;

    /// <summary>
    /// Метод SetCommand устанавливает команду для последующего выполнения.
    /// </summary>
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    /// <summary>
    /// Метод ExecuteCommand выполняет установленную команду.
    /// </summary>
    public Task ExecuteCommand()
    {
        command.Execute();
        return Task.CompletedTask;
    }
}