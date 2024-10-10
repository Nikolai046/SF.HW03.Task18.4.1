namespace SF.HW03.Task18._4._1.PLL.Handlers;

/// <summary>
/// Класс OutputPathInputHandler обрабатывает ввод пути для сохранения видео.
/// </summary>
public class OutputPathInputHandler : IInputHandler
{
    /// <summary>
    /// Метод GetInput запрашивает у пользователя путь для сохранения видео и возвращает его.
    /// </summary>
    public string GetInput()
    {
        while (true)
        {
            Console.Write("\nВведите путь для сохранения видео: ");
            var path = Console.ReadLine();
            Console.WriteLine();

            var pathParts = path.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar },
                StringSplitOptions.RemoveEmptyEntries);

            // Используем Path.Combine для правильного объединения частей пути
            var directoryPath = pathParts.Aggregate(string.Empty, Path.Combine);

            // Добавляем имя файла к пути
            var fullPath = Path.Combine(directoryPath, "video.mp4");

            // Проверяем, существует ли директория
            if (Directory.Exists(directoryPath))
                return fullPath;
            Console.WriteLine($"Директория {directoryPath} не существует.");
        }
    }
}