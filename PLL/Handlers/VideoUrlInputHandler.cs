namespace SF.HW03.Task18._4._1.PLL.Handlers;

/// <summary>
/// Класс VideoUrlInputHandler обрабатывает ввод URL видео с YouTube.
/// </summary>
public class VideoUrlInputHandler : IInputHandler
{
    /// <summary>
    /// Метод GetInput запрашивает у пользователя ссылку на видео и возвращает её.
    /// </summary>
    public string GetInput()
    {
        Console.WriteLine("Введите ссылку на YouTube видео:");
        var url = Console.ReadLine();

        while (string.IsNullOrEmpty(url))
        {
            Console.WriteLine("URL не может быть пустым. Пожалуйста, введите корректную ссылку:");
            url = Console.ReadLine();
        }

        return url;
    }
}