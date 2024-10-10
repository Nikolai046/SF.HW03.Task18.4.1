namespace SF.HW03.Task18._4._1.BLL.Commands;

/// <summary>
/// Интерфейс ICommand определяет метод Execute, который должен быть реализован в командах.
/// </summary>
public interface ICommand
{
    Task Execute();
}